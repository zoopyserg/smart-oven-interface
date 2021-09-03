using Oven_Interface.Controllers;
using Oven_Interface.Models;
using Solid.Arduino;
using Solid.Arduino.Firmata;
using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows.Forms;

namespace Oven_Interface
{
    public partial class Dashboard : Form
    {
        List<Bread> breads = new List<Bread>();
        List<TemperaturePoint> temperaturePoints = new List<TemperaturePoint>();
        List<PressurePoint> pressurePoints = new List<PressurePoint>();
        List<ValvePoint> valvePoints = new List<ValvePoint>();

        List<LaunchInstance> launchInstances = new List<LaunchInstance>();
        System.Timers.Timer timer;
        int minutesPassed;
        Bread runningProgram;

        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();

            ISerialConnection connection = GetConnection(this.labelConnectionStatus);

            if (connection != null)
                using (var session = new ArduinoSession(connection))
                    PerformBasicTest(session, this.labelLastCommandStatus);
        }
        private void UpdateBinding()
        {
            programsListBox.DataSource = breads;
            programsListBox.DisplayMember = "DisplayString";

            if ((breads.Count > 0) && (programsListBox.SelectedIndex > -1))
            {
                int selectedBreadId = breads[programsListBox.SelectedIndex].Id;
                temperaturePoints = TemperaturePointsController.Index(selectedBreadId);
                pressurePoints = PressurePointsController.Index(selectedBreadId);
                valvePoints = ValvePointsController.Index(selectedBreadId);
                launchInstances = LaunchInstancesController.Index(selectedBreadId);
            }


            // update list boxes
            temperaturePointsListBox.DataSource = temperaturePoints;
            temperaturePointsListBox.DisplayMember = "DisplayString";

            pressurePointsListBox.DataSource = pressurePoints;
            pressurePointsListBox.DisplayMember = "DisplayString";

            valvePointsListBox.DataSource = valvePoints;
            valvePointsListBox.DisplayMember = "DisplayString";

            historyListBox.DataSource = launchInstances;
            historyListBox.DisplayMember = "DisplayString";

            // update temperatures chart
            chartTemperatures.DataSource = temperaturePoints;

            chartTemperatures.DataBind();

            // update pressures chart
            pressuresChart.DataSource = pressurePoints;
            
            pressuresChart.DataBind();

            // update valve chart
            valveChart.DataSource = valvePoints;
            
            valveChart.DataBind();

        }

        private static ISerialConnection GetConnection(Label ConnectionStatusLabel)
        {
            Console.WriteLine("Searching Arduino connection...");
            ISerialConnection connection = EnhancedSerialConnection.Find();

            if (connection == null)
                ConnectionStatusLabel.Text = "Немає з'єднання з контролером. Перевірте, що Arduino включений в USB порт.";
            else
                ConnectionStatusLabel.Text = $"Arduino контролер підключений до порта {connection.PortName}.";

            return connection;
        }

        private static void PerformBasicTest(IFirmataProtocol session, Label SignalStatusLabel)
        {
            var firmware = session.GetFirmware();
            var protocolVersion = session.GetProtocolVersion();

            session.SetDigitalPinMode(13, PinMode.DigitalOutput);
            session.SetDigitalPin(13, true);
            SignalStatusLabel.Text = "13й пін включено";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Turn On 13th Pin
            ISerialConnection connection = GetConnection(this.labelConnectionStatus);

            if (connection != null)
                using (var session = new ArduinoSession(connection))
                    TurnOn(session, this.labelLastCommandStatus);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Turn Off 13th Pin
            ISerialConnection connection = GetConnection(this.labelConnectionStatus);

            if (connection != null)
                using (var session = new ArduinoSession(connection))
                    TurnOff(session, this.labelLastCommandStatus);
        }

        private static void TurnOn(IFirmataProtocol session, Label SignalStatusLabel)
        {
            session.SetDigitalPinMode(13, PinMode.DigitalOutput);
            session.SetDigitalPin(13, true);
            SignalStatusLabel.Text = "13й пін включено";
        }

        private static void TurnOff(IFirmataProtocol session, Label SignalStatusLabel)
        {
            session.SetDigitalPinMode(13, PinMode.DigitalOutput);
            session.SetDigitalPin(13, false);
            SignalStatusLabel.Text = "13й пін виключено";
        }

        private static void DisplayPortCapabilities()
        {
            using (var session = new ArduinoSession(new EnhancedSerialConnection("COM3", SerialBaudRate.Bps_57600)))
            {
                BoardCapability cap = session.GetBoardCapability();
                Console.WriteLine();
                Console.WriteLine("Board Capability:");

                foreach (var pin in cap.Pins)
                {
                    Console.WriteLine("Pin {0}: Input: {1}, Output: {2}, Analog: {3}, Analog-Res: {4}, PWM: {5}, PWM-Res: {6}, Servo: {7}, Servo-Res: {8}, Serial: {9}, Encoder: {10}, Input-pullup: {11}",
                        pin.PinNumber,
                        pin.DigitalInput,
                        pin.DigitalOutput,
                        pin.Analog,
                        pin.AnalogResolution,
                        pin.Pwm,
                        pin.PwmResolution,
                        pin.Servo,
                        pin.ServoResolution,
                        pin.Serial,
                        pin.Encoder,
                        pin.InputPullup);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            breads = BreadsController.Index();
            // how do I get the ID of a selected bread?
            UpdateBinding();

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            minutesPassed = 0;
            timer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                if (minutesPassed >= runningProgram.Duration)
                {
                    CommitProgramFinilization();
                    timer.Stop();
                }
                else
                {
                    minutesPassed += 1;
                    // perform temperature adjustments
                    BreadsController.Update(runningProgram.Id, minutesPassed);
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = runningProgram.Duration;
                    progressBar1.Value = minutesPassed;
                    minutesLeftLabel.Text = (runningProgram.Duration - minutesPassed).ToString();
                    int persistedIndex = programsListBox.SelectedIndex;
                    breads = BreadsController.Index();
                    UpdateBinding();
                    programsListBox.SelectedIndex = persistedIndex;
                }
            }));
        }

        public void CommitProgramFinilization()
        {
            int persistedIndex = programsListBox.SelectedIndex;
            labelLastCommandStatus.Text = $"Програму {runningProgram.Name} завершено";
            BreadsController.Finish(runningProgram.Id);
            runningProgram = null;
            minutesPassed = 0;
            progressBar1.Value = 0;
            breads = BreadsController.Index();
            UpdateBinding();
            programsListBox.SelectedIndex = persistedIndex;
        }

        private void showBreadsButton_Click(object sender, EventArgs e)
        {
            breads = BreadsController.Index();

            UpdateBinding();
        }

        private void createBread_Click(object sender, EventArgs e)
        {
            BreadsController.Create(newProgramNameTextBox.Text);
            newProgramNameTextBox.Text = "";
            breads = BreadsController.Index();
            UpdateBinding();
        }

        private void programsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void createTemperatureButton_Click(object sender, EventArgs e)
        {
            int persistedIndex = programsListBox.SelectedIndex;
            TemperaturePointsController.Create(breads[persistedIndex].Id, Decimal.ToInt32(newTemperaturePointMinuteTextBox.Value), Decimal.ToInt32(newTemperaturePointValueTextBox.Value));
            newTemperaturePointMinuteTextBox.Value = 0;
            newTemperaturePointValueTextBox.Value = 0;
            breads = BreadsController.Index();
            UpdateBinding();
            programsListBox.SelectedIndex = persistedIndex;
        }

        private void buttonDeleteProgram_Click(object sender, EventArgs e)
        {
            BreadsController.Delete(breads[programsListBox.SelectedIndex].Id);
            breads = BreadsController.Index();
            UpdateBinding();
        }

        private void deleteTemperaturePointButton_Click(object sender, EventArgs e)
        {
            int persistedIndex = programsListBox.SelectedIndex;
            TemperaturePointsController.Delete(temperaturePoints[temperaturePointsListBox.SelectedIndex].Id);
            breads = BreadsController.Index();
            UpdateBinding();
            programsListBox.SelectedIndex = persistedIndex;
        }

        private void showTemperaturePointsButton_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void buttonPreviousProgram_Click(object sender, EventArgs e)
        {
            int persistedIndex = programsListBox.SelectedIndex;
            if (persistedIndex > 0)
            {
                programsListBox.SelectedIndex = persistedIndex - 1;
            }
        }

        private void nextProgram_Click(object sender, EventArgs e)
        {
            int persistedIndex = programsListBox.SelectedIndex;
            if (persistedIndex < (breads.Count - 1))
            {
                programsListBox.SelectedIndex = persistedIndex + 1;
            }
        }

        private void previousTemperaturePointButton_Click(object sender, EventArgs e)
        {
            int persistedIndex = temperaturePointsListBox.SelectedIndex;
            if (persistedIndex > 0)
            {
                temperaturePointsListBox.SelectedIndex = persistedIndex - 1;
            }
        }

        private void nextTemperaturePointButton_Click(object sender, EventArgs e)
        {
            int persistedIndex = temperaturePointsListBox.SelectedIndex;
            if (persistedIndex < (temperaturePoints.Count - 1))
            {
                temperaturePointsListBox.SelectedIndex = persistedIndex + 1;
            }
        }

        private void startProgramButton_Click(object sender, EventArgs e)
        {
            // создать инстанс запуска. для начала. факт запуска.
            int persistedIndex = programsListBox.SelectedIndex;
            runningProgram = breads[persistedIndex];
            LaunchInstancesController.Create(runningProgram.Id);
            breads = BreadsController.Index();
            UpdateBinding();
            programsListBox.SelectedIndex = persistedIndex;

            timer.Start();

            // и каждую секунду обновлять статус запуска (сколько минут прошло).
            // и выставлять тот градус который надо выставлять согласно последней минуте.
            // узнать сколько времени должен играть таймер (минуту последней температуры)
            // стартануть таймер
            // а таймер это воркер который смотрит сколько времени прошло и ... или как там я планировал...
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            Application.DoEvents();
        }

        private void stopProgramButton_Click(object sender, EventArgs e)
        {
            CommitProgramFinilization();
            timer.Stop();
        }

        private void pauseProgramButton_Click(object sender, EventArgs e)
        {
            CommitProgramFinilization();
            timer.Stop();
        }

        private void continueProgramButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void previousPressurePointButton_Click(object sender, EventArgs e)
        {
            int persistedIndex = pressurePointsListBox.SelectedIndex;
            if (persistedIndex > 0)
            {
                pressurePointsListBox.SelectedIndex = persistedIndex - 1;
            }
        }

        private void nextPressurePointButton_Click(object sender, EventArgs e)
        {
            int persistedIndex = pressurePointsListBox.SelectedIndex;
            if (persistedIndex < (pressurePoints.Count - 1))
            {
                pressurePointsListBox.SelectedIndex = persistedIndex + 1;
            }
        }

        private void deletePressurePointButton_Click(object sender, EventArgs e)
        {
            int persistedIndex = programsListBox.SelectedIndex;
            PressurePointsController.Delete(pressurePoints[pressurePointsListBox.SelectedIndex].Id);
            breads = BreadsController.Index();
            UpdateBinding();
            programsListBox.SelectedIndex = persistedIndex;
        }

        private void showPressurePointsButton_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void previousValvePointButton_Click(object sender, EventArgs e)
        {
            int persistedIndex = valvePointsListBox.SelectedIndex;
            if (persistedIndex > 0)
            {
                valvePointsListBox.SelectedIndex = persistedIndex - 1;
            }
        }

        private void nextValvePointButton_Click(object sender, EventArgs e)
        {
            int persistedIndex = valvePointsListBox.SelectedIndex;
            if (persistedIndex < (valvePoints.Count - 1))
            {
                valvePointsListBox.SelectedIndex = persistedIndex + 1;
            }
        }

        private void deleteValvePointButton_Click(object sender, EventArgs e)
        {
            int persistedIndex = programsListBox.SelectedIndex;
            ValvePointsController.Delete(pressurePoints[valvePointsListBox.SelectedIndex].Id);
            breads = BreadsController.Index();
            UpdateBinding();
            programsListBox.SelectedIndex = persistedIndex;
        }

        private void showValvepointsButton_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void createPressurePointButton_Click(object sender, EventArgs e)
        {
            int persistedIndex = programsListBox.SelectedIndex;
            PressurePointsController.Create(breads[persistedIndex].Id, Decimal.ToInt32(newPressurePointMinuteTextBox.Value), Decimal.ToInt32(newPressurePointValueTextBox.Value));
            newPressurePointMinuteTextBox.Value = 0;
            newPressurePointValueTextBox.Value = 0;
            breads = BreadsController.Index();
            UpdateBinding();
            programsListBox.SelectedIndex = persistedIndex;
        }

        private void createValvePointButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            int persistedIndex = programsListBox.SelectedIndex;
            ValvePointsController.Create(breads[persistedIndex].Id, Decimal.ToInt32(newValvePointMinuteTextBox.Value), Decimal.ToInt32(newValvePointValueTextBox.Value));
            newValvePointMinuteTextBox.Value = 0;
            newValvePointValueTextBox.Value = 0;
            breads = BreadsController.Index();
            UpdateBinding();
            programsListBox.SelectedIndex = persistedIndex;
        }
    }
}
