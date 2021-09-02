using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oven_Interface.Models;
using Solid.Arduino;
using Solid.Arduino.Firmata;

namespace Oven_Interface
{
    public partial class Dashboard : Form
    {
        List<Bread> breads = new List<Bread>();
        List<TemperaturePoint> temperaturePoints = new List<TemperaturePoint>();
        List<LaunchInstance> launchInstances = new List<LaunchInstance>();

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
            programsListBox.DisplayMember = "Name";

            if ((breads.Count > 0) && (programsListBox.SelectedIndex > -1))
            {
                DataAccess db = new DataAccess();
                temperaturePoints = db.GetTemperaturePoints(breads[programsListBox.SelectedIndex].Id);
                launchInstances = db.GetLaunchInstances(breads[programsListBox.SelectedIndex].Id);
            }

            temperaturePointsListBox.DataSource = temperaturePoints;
            temperaturePointsListBox.DisplayMember = "DisplayString";

            historyListBox.DataSource = launchInstances;
            historyListBox.DisplayMember = "DisplayString";

            chartTemperatures.DataSource = temperaturePoints;
            chartTemperatures.Series[0].XValueMember = "Minute";
            chartTemperatures.Series[0].YValueMembers = "Value";

            chartTemperatures.ChartAreas[0].AxisX.Title = "Час (хв)";
            chartTemperatures.ChartAreas[0].AxisY.Title = "Температура (С)";

            chartTemperatures.ChartAreas[0].AxisX.Minimum = 0;
            chartTemperatures.ChartAreas[0].AxisY.Minimum = 0;

            chartTemperatures.DataBind();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            DataAccess db = new DataAccess();
            breads = db.GetBreads();
            // how do I get the ID of a selected bread?
            UpdateBinding();
        }

        private void showBreadsButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            breads = db.GetBreads();
            
            UpdateBinding();
        }

        private void createBread_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertBread(newProgramNameTextBox.Text);
            newProgramNameTextBox.Text = "";
            breads = db.GetBreads();
            UpdateBinding();
        }

        private void programsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBinding();
        }

        private void createTemperatureButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            int persistedIndex = programsListBox.SelectedIndex;
            db.InsertTemperaturePoint(breads[persistedIndex].Id, Int32.Parse(newTemperaturePointMinuteTextBox.Text), Int32.Parse(newTemperaturePointValueTextBox.Text));
            newTemperaturePointMinuteTextBox.Text = "";
            newTemperaturePointValueTextBox.Text = "";
            breads = db.GetBreads();
            UpdateBinding();
            programsListBox.SelectedIndex = persistedIndex;
        }

        private void buttonDeleteProgram_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.DeleteProgram(breads[programsListBox.SelectedIndex].Id);
            breads = db.GetBreads();
            UpdateBinding();
        }

        private void deleteTemperaturePointButton_Click(object sender, EventArgs e)
        {
            int persistedIndex = programsListBox.SelectedIndex;
            DataAccess db = new DataAccess();
            db.DeleteTemperaturePoint(temperaturePoints[temperaturePointsListBox.SelectedIndex].Id);
            breads = db.GetBreads();
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
            DataAccess db = new DataAccess();

            int persistedIndex = programsListBox.SelectedIndex;
            db.InsertLaunchInstance(breads[persistedIndex].Id);
            breads = db.GetBreads();
            UpdateBinding();
            programsListBox.SelectedIndex = persistedIndex;

            // и каждую секунду обновлять статус запуска (сколько минут прошло).
            // и выставлять тот градус который надо выставлять согласно последней минуте.
            // узнать сколько времени должен играть таймер (минуту последней температуры)
            // стартануть таймер
            // а таймер это воркер который смотрит сколько времени прошло и ... или как там я планировал...
        }
    }
}
