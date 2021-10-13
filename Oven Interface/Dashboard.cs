using Oven_Interface.Controllers;
using Oven_Interface.Models;
using Solid.Arduino;
using Solid.Arduino.Firmata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Oven_Interface
{
    public partial class Dashboard : Form, IObserver<AnalogState>

    {
        List<Bread> breads = new List<Bread>();
        List<TemperaturePoint> temperaturePoints = new List<TemperaturePoint>();
        List<PressurePoint> pressurePoints = new List<PressurePoint>();
        List<ValvePoint> valvePoints = new List<ValvePoint>();
        //List<StatusLine> statusLines = new List<StatusLine>();

        public List<StatusLine> statusLines { get; set; }

        List<LaunchInstance> launchInstances = new List<LaunchInstance>();
        System.Timers.Timer timer;
        int minutesPassed;
        Bread runningProgram;

        public Dashboard()
        {
            this.statusLines = new List<StatusLine>();

            InitializeComponent();
            UpdateBinding();

            ISerialConnection connection = GetConnection();

            if (connection != null)
                using (var session = new ArduinoSession(connection))
                    PerformInitialization(session);

        }
        private void UpdateBinding(bool refreshEverything = true)
        {
            int persistedIndex = -1;
            
            if (refreshEverything)
            {
                breads = BreadsController.Index();
            }
            
            if ((programsListBox.SelectedIndex < 0) || (programsListBox.SelectedIndex > (breads.Count - 1)))
            {
                if (breads.Count > 0)
                {
                    persistedIndex = 0;
                } else
                {
                    persistedIndex = -1;
                }
            } else
            {
                persistedIndex = programsListBox.SelectedIndex;
            }

            if ((breads.Count > 0) && (persistedIndex > -1))
            {
                int selectedBreadId = breads[persistedIndex].Id;
                temperaturePoints = TemperaturePointsController.Index(selectedBreadId);
                pressurePoints = PressurePointsController.Index(selectedBreadId);
                valvePoints = ValvePointsController.Index(selectedBreadId);
                launchInstances = LaunchInstancesController.Index(selectedBreadId);
            }

            UpdateProgramsListBox();
            UpdatePressurePointsListBox();
            UpdateTemperaturePointsListBox();
            UpdateValvePointsListBox();
            UpdateHistoryListBox();

            UpdatePressurePointsChart();
            UpdateValvePointsChart();
            UpdateTemperaturePointsChart();

            if (refreshEverything)
            {
                programsListBox.SelectedIndex = persistedIndex;
            }
        }

        private void UpdateProgramsListBox()
        {
            programsListBox.DataSource = null;
            programsListBox.DataSource = breads;
            programsListBox.DisplayMember = "DisplayString";
        }

        private void UpdateHistoryListBox()
        {
            historyListBox.DataSource = null;
            historyListBox.DataSource = launchInstances;
            historyListBox.DisplayMember = "DisplayString";
        }

        private void UpdatePressurePointsListBox()
        {
            pressurePointsListBox.DataSource = null;
            pressurePointsListBox.DataSource = pressurePoints;
            pressurePointsListBox.DisplayMember = "DisplayString";
        }
        private void UpdateTemperaturePointsListBox()
        {
            temperaturePointsListBox.DataSource = null;
            temperaturePointsListBox.DataSource = temperaturePoints;
            temperaturePointsListBox.DisplayMember = "DisplayString";
        }
        private void UpdateValvePointsListBox()
        {
            valvePointsListBox.DataSource = null;
            valvePointsListBox.DataSource = valvePoints;
            valvePointsListBox.DisplayMember = "DisplayString";
        }

        public void UpdateStatusListBox(string name)
        {
            StatusLine statusLine = new StatusLine();
            statusLine.Name = name;
            statusLine.CreatedAt = DateTime.Now;
            this.statusLines.Add(statusLine);
            statusListBox.DataSource = null;
            statusListBox.DataSource = this.statusLines;
            statusListBox.DisplayMember = "DisplayString";
        }

        private void UpdateTemperaturePointsChart()
        {
            chartTemperatures.DataSource = temperaturePoints;
            chartTemperatures.DataBind();
        }

        private void UpdatePressurePointsChart()
        {
            pressuresChart.DataSource = pressurePoints;
            pressuresChart.DataBind();
        }

        private void UpdateValvePointsChart()
        {
            valveChart.DataSource = valvePoints;
            valveChart.DataBind();
        }

        private ISerialConnection GetConnection()
        {
            UpdateStatusListBox("Searching Arduino connection...");
            ISerialConnection connection = EnhancedSerialConnection.Find();

            if (connection == null)
                UpdateStatusListBox("Немає з'єднання з контролером. Перевірте, що Arduino включений в USB порт.");
            else
                UpdateStatusListBox($"Arduino контролер підключений до порта {connection.PortName}.");

            return connection;
        }

        private void PerformInitialization(IFirmataProtocol session)
        {
            var firmware = session.GetFirmware();
            var protocolVersion = session.GetProtocolVersion();

            session.SetDigitalPinMode(2, PinMode.DigitalOutput);
            session.SetDigitalPinMode(3, PinMode.DigitalOutput);
            session.SetDigitalPinMode(4, PinMode.DigitalOutput);
            session.SetDigitalPinMode(5, PinMode.DigitalOutput);
            session.SetDigitalPinMode(6, PinMode.DigitalOutput);
            session.SetDigitalPinMode(7, PinMode.DigitalOutput);
            session.SetDigitalPinMode(8, PinMode.DigitalOutput);
            session.SetDigitalPinMode(9, PinMode.DigitalOutput);
            session.SetDigitalPinMode(10, PinMode.DigitalOutput);
            session.SetDigitalPinMode(11, PinMode.DigitalOutput);
            session.SetDigitalPinMode(12, PinMode.DigitalOutput);
            session.SetDigitalPinMode(13, PinMode.DigitalOutput);

            // посылаю true потому что купил плату которая при LOW включена... пофиксить новой платой.
            session.SetDigitalPin(2, true);
            session.SetDigitalPin(3, true);
            session.SetDigitalPin(4, true);
            session.SetDigitalPin(5, true);
            session.SetDigitalPin(6, true);
            session.SetDigitalPin(7, true);
            session.SetDigitalPin(8, true);
            session.SetDigitalPin(9, true);
            session.SetDigitalPin(10, true);
            session.SetDigitalPin(11, true);
            session.SetDigitalPin(12, true);
            session.SetDigitalPin(13, true);

            UpdateStatusListBox("Готовий до роботи.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ISerialConnection connection = GetConnection();

            if (connection != null)
                using (var session = new ArduinoSession(connection))
                    TestPinsController.TurnOnPin(this, session, 13);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ISerialConnection connection = GetConnection();

            if (connection != null)
                using (var session = new ArduinoSession(connection))
                    TestPinsController.TurnOffPin(this, session, 13);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                    UpdateBinding(false);
                    programsListBox.SelectedIndex = persistedIndex;
                }
            }));
        }

        public void CommitProgramFinilization()
        {
            UpdateStatusListBox($"Програму {runningProgram.Name} завершено");
            BreadsController.Finish(runningProgram.Id);
            runningProgram = null;
            minutesPassed = 0;
            progressBar1.Value = 0;
            UpdateBinding();
        }

        private void createBread_Click(object sender, EventArgs e)
        {
            BreadsController.Create(newProgramNameTextBox.Text);
            newProgramNameTextBox.Text = "";
            UpdateBinding();
        }

        private void programsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBinding(false);
        }

        private void createTemperatureButton_Click(object sender, EventArgs e)
        {
            int persistedIndex = programsListBox.SelectedIndex;
            TemperaturePointsController.Create(breads[persistedIndex].Id, Decimal.ToInt32(newTemperaturePointMinuteTextBox.Value), Decimal.ToInt32(newTemperaturePointValueTextBox.Value));
            newTemperaturePointMinuteTextBox.Value = 0;
            newTemperaturePointValueTextBox.Value = 0;
            UpdateBinding();
        }

        private void buttonDeleteProgram_Click(object sender, EventArgs e)
        {
            BreadsController.Delete(breads[programsListBox.SelectedIndex].Id);
            UpdateBinding();
        }

        private void deleteTemperaturePointButton_Click(object sender, EventArgs e)
        {
            TemperaturePointsController.Delete(temperaturePoints[temperaturePointsListBox.SelectedIndex].Id);
            UpdateBinding();
        }

        private void buttonPreviousProgram_Click(object sender, EventArgs e)
        {
            selectPreviousElementInTheList(programsListBox);
        }

        private void nextProgram_Click(object sender, EventArgs e)
        {
            selectNextElementInTheList<Bread>(programsListBox, breads);
        }

        private void previousTemperaturePointButton_Click(object sender, EventArgs e)
        {
            selectPreviousElementInTheList(temperaturePointsListBox);
        }

        private void nextTemperaturePointButton_Click(object sender, EventArgs e)
        {
            selectNextElementInTheList<TemperaturePoint>(temperaturePointsListBox, temperaturePoints);
        }

        private void selectPreviousElementInTheList(ListBox listBox)
        {
            int persistedIndex = listBox.SelectedIndex;
            if (persistedIndex > 0)
            {
                listBox.SelectedIndex = persistedIndex - 1;
            }
        }

        private void selectNextElementInTheList<T>(ListBox listBox, List<T> relatedVariable)
        {
            int persistedIndex = listBox.SelectedIndex;
            if (persistedIndex < (relatedVariable.Count - 1))
            {
                listBox.SelectedIndex = persistedIndex + 1;
            }
        }

        private void startProgramButton_Click(object sender, EventArgs e)
        {
            // создать инстанс запуска. для начала. факт запуска.
            int persistedIndex = programsListBox.SelectedIndex;
            runningProgram = breads[persistedIndex];
            LaunchInstancesController.Create(runningProgram.Id);
            UpdateBinding();
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
            selectPreviousElementInTheList(pressurePointsListBox);
        }

        private void nextPressurePointButton_Click(object sender, EventArgs e)
        {
            selectNextElementInTheList<PressurePoint>(pressurePointsListBox, pressurePoints);
        }

        private void deletePressurePointButton_Click(object sender, EventArgs e)
        {
            PressurePointsController.Delete(pressurePoints[pressurePointsListBox.SelectedIndex].Id);
            UpdateBinding();
        }

        private void previousValvePointButton_Click(object sender, EventArgs e)
        {
            selectPreviousElementInTheList(valvePointsListBox);
        }

        private void nextValvePointButton_Click(object sender, EventArgs e)
        {
            selectNextElementInTheList<ValvePoint>(valvePointsListBox, valvePoints);
        }

        private void deleteValvePointButton_Click(object sender, EventArgs e)
        {
            ValvePointsController.Delete(valvePoints[valvePointsListBox.SelectedIndex].Id);
            UpdateBinding();
        }

        private void createPressurePointButton_Click(object sender, EventArgs e)
        {
            int persistedIndex = programsListBox.SelectedIndex;
            PressurePointsController.Create(breads[persistedIndex].Id, Decimal.ToInt32(newPressurePointMinuteTextBox.Value), Decimal.ToInt32(newPressurePointValueTextBox.Value));
            newPressurePointMinuteTextBox.Value = 0;
            newPressurePointValueTextBox.Value = 0;
            UpdateBinding();
        }

        private void createValvePointButton_Click(object sender, EventArgs e)
        {
            int persistedIndex = programsListBox.SelectedIndex;
            ValvePointsController.Create(breads[persistedIndex].Id, Decimal.ToInt32(newValvePointMinuteTextBox.Value), Decimal.ToInt32(newValvePointValueTextBox.Value));
            newValvePointMinuteTextBox.Value = 0;
            newValvePointValueTextBox.Value = 0;
            UpdateBinding();
        }

        private void refreshInfoButton_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISerialConnection connection = GetConnection();

            if (connection != null)
                using (var session = new ArduinoSession(connection))
                    TestPinsController.TurnOnPin(this, session, 4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ISerialConnection connection = GetConnection();

            if (connection != null)
                using (var session = new ArduinoSession(connection))
                    TestPinsController.TurnOnPin(this, session, 3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ISerialConnection connection = GetConnection();

            if (connection != null)
                using (var session = new ArduinoSession(connection))
                    TestPinsController.TurnOnPin(this, session, 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISerialConnection connection = GetConnection();

            if (connection != null)
                using (var session = new ArduinoSession(connection))
                    TestPinsController.TurnOffPin(this, session, 4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ISerialConnection connection = GetConnection();

            if (connection != null)
                using (var session = new ArduinoSession(connection))
                    TestPinsController.TurnOffPin(this, session, 3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ISerialConnection connection = GetConnection();

            if (connection != null)
                using (var session = new ArduinoSession(connection))
                    TestPinsController.TurnOffPin(this, session, 2);
        }

        private void DisplayPortCapabilities()
        {
            ISerialConnection connection = GetConnection();

            if (connection != null)
            {
                using (var session = new ArduinoSession(connection))
                {
                    BoardCapability cap = session.GetBoardCapability();
                    UpdateStatusListBox("Board Capability:");

                    foreach (var pin in cap.Pins)
                    {
                        UpdateStatusListBox($"Pin {pin.PinNumber}: Input: {pin.DigitalInput}, Output: {pin.DigitalOutput}, Analog: {pin.Analog}, Analog-Res: {pin.AnalogResolution}, PWM: {pin.Pwm}, PWM-Res: {pin.PwmResolution}, Servo: {pin.Servo}, Servo-Res: {pin.ServoResolution}, Serial: {pin.Serial}, Encoder: {pin.Encoder}, Input-pullup: {pin.InputPullup}");
                    }
                }
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            DisplayPortCapabilities();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            ISerialConnection connection = GetConnection();

            if (connection != null)
            {
                using (var session = new ArduinoSession(connection))
                {
                    IFirmataProtocol firmata = session;

                    firmata.AnalogStateReceived += Session_OnAnalogStateReceived;
                    firmata.DigitalStateReceived += Session_OnDigitalStateReceived;

                    Firmware firm = firmata.GetFirmware();
                    UpdateStatusListBox($"Firmware: {firm.Name} {firm.MajorVersion}.{firm.MinorVersion}");

                    ProtocolVersion version = firmata.GetProtocolVersion();
                    UpdateStatusListBox($"Protocol version: {version.Major}.{version.Minor}");

                    BoardCapability cap = firmata.GetBoardCapability();
                    UpdateStatusListBox("Board Capability:");

                    foreach (var pin in cap.Pins)
                    {
                        UpdateStatusListBox($"Pin {pin.PinNumber}: Input: {pin.DigitalInput}, Output: {pin.DigitalOutput}, Analog: {pin.Analog}, Analog-Res: {pin.AnalogResolution}, PWM: {pin.Pwm}, PWM-Res: {pin.PwmResolution}, Servo: {pin.Servo}, Servo-Res: {pin.ServoResolution}, Serial: {pin.Serial}, Encoder: {pin.Encoder}, Input-pullup: {pin.InputPullup}");
                    }
                    
                    var analogMapping = firmata.GetBoardAnalogMapping();
                    UpdateStatusListBox("Analog channel mappings:");

                    foreach (var mapping in analogMapping.PinMappings)
                    {
                        UpdateStatusListBox($"Channel {mapping.Channel} is mapped to pin {mapping.PinNumber}.");
                    }

                    firmata.ResetBoard();

                    UpdateStatusListBox("Digital port states:");

                    foreach (var pincap in cap.Pins.Where(c => (c.DigitalInput || c.DigitalOutput) && !c.Analog))
                    {
                        var pinState = firmata.GetPinState(pincap.PinNumber);
                        UpdateStatusListBox($"Pin {pincap.PinNumber}: Mode = {pinState.Mode}, Value = {pinState.Value}");
                    }
                    
                    firmata.SetDigitalPort(0, 0x04);
                    firmata.SetDigitalPort(1, 0xff);
                    firmata.SetDigitalPinMode(10, PinMode.DigitalOutput);
                    firmata.SetDigitalPinMode(11, PinMode.ServoControl);
                    firmata.SetDigitalPin(11, 90);

                    firmata.SetAnalogReportMode(5, true);

                    Thread.Sleep(500);
                    int hi = 0;

                    for (int a = 0; a <= 179; a += 1)
                    {
                        firmata.SetDigitalPin(11, a);
                        Thread.Sleep(100);
                        firmata.SetDigitalPort(1, hi);
                        hi ^= 4;
                        UpdateStatusListBox($"{a};");
                    }

                    firmata.SetDigitalPinMode(6, PinMode.DigitalInput);

                    //firmata.SetDigitalPortState(2, 255);
                    //firmata.SetDigitalPortState(3, 255);

                    firmata.SetSamplingInterval(500);
                    firmata.SetAnalogReportMode(0, false);

                    UpdateStatusListBox("Setting digital report modes:");
                    firmata.SetDigitalReportMode(0, true);
                    firmata.SetDigitalReportMode(1, true);
                    firmata.SetDigitalReportMode(2, true);
                    
                    foreach (var pinCap in cap.Pins.Where(c => (c.DigitalInput || c.DigitalOutput) && !c.Analog))
                    {
                        PinState state = firmata.GetPinState(pinCap.PinNumber);
                        UpdateStatusListBox($"Digital {state.Mode} pin {state.PinNumber}: {state.Value}");
                    }
                    
                    firmata.SetAnalogReportMode(0, false);
                    firmata.SetDigitalReportMode(0, false);
                    firmata.SetDigitalReportMode(1, false);
                    firmata.SetDigitalReportMode(2, false);
                    UpdateStatusListBox("Ready.");
                }
            }
        }

        public void OnNext(AnalogState state)
        {
            UpdateStatusListBox("something");
        }

        public void OnError(Exception error)
        {
            UpdateStatusListBox("error");
        }

        public void OnCompleted()
        {
            UpdateStatusListBox("completed");
        }

        private void Session_OnDigitalStateReceived(object sender, FirmataEventArgs<DigitalPortState> eventArgs)
        {
            var smth = eventArgs.Value.IsSet(6) ? 'X' : 'O';
            UpdateStatusListBox($"Digital level of port {eventArgs.Value.Port}: { smth }");
        }

        private void Session_OnAnalogStateReceived(object sender, FirmataEventArgs<AnalogState> eventArgs)
        {
            UpdateStatusListBox($"Analog level of pin {eventArgs.Value.Channel}: {eventArgs.Value.Level}");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ISerialConnection connection = GetConnection();

            if (connection != null)
            {
                using (var session = new ArduinoSession(connection))
                {
                    //PinState pinState = session.GetPinState(19);
                    //string result = pinState.Value.ToString();
                    //UpdateStatusListBox(result);

                    //PinState pinState;
                    //string result;

                    session.SetAnalogReportMode(5, true);
                    session.AnalogStateReceived += Session_AnalogStateReceived;

                    //session.SetDigitalPin(10, true);
                    //Console.WriteLine("Command sent: Light on (pin 10)");
                    //Console.WriteLine("Press a key");
                    //Console.ReadKey(true);
                    //session.SetDigitalPin(10, false);
                    //Console.WriteLine("Command sent: Light off");
                }
            }
        }

        private void Session_AnalogStateReceived(object sender, FirmataEventArgs<AnalogState> eventArgs)
        {
            UpdateStatusListBox($"Analog level of pin {eventArgs.Value.Channel}: {eventArgs.Value.Level}");
        }
    }
}
