using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Solid.Arduino;
using Solid.Arduino.Firmata;

namespace Oven_Interface
{
    public partial class Dashboard : Form
    {
        List<Bread> breads = new List<Bread>();

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
            breadsListBox.DataSource = breads;
            breadsListBox.DisplayMember = "Name";
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
                ConnectionStatusLabel.Text = "No connection found. Make shure your Arduino board is attached to a USB port.";
            else
                ConnectionStatusLabel.Text = $"Connected to port {connection.PortName} at {connection.BaudRate} baud.";

            return connection;
        }

        private static void PerformBasicTest(IFirmataProtocol session, Label SignalStatusLabel)
        {
            var firmware = session.GetFirmware();
            /// Console.WriteLine($"Firmware: {firmware.Name} version {firmware.MajorVersion}.{firmware.MinorVersion}");
            var protocolVersion = session.GetProtocolVersion();
            /// Console.WriteLine($"Firmata protocol version {protocolVersion.Major}.{protocolVersion.Minor}");

            session.SetDigitalPinMode(13, PinMode.DigitalOutput);
            session.SetDigitalPin(13, true);
            SignalStatusLabel.Text = "Command sent: Light on (pin 13)";
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
            SignalStatusLabel.Text = "Command sent: Light on (pin 13)";
        }

        private static void TurnOff(IFirmataProtocol session, Label SignalStatusLabel)
        {
            session.SetDigitalPinMode(13, PinMode.DigitalOutput);
            session.SetDigitalPin(13, false);
            SignalStatusLabel.Text = "Command sent: Light off (pin 13)";
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
            chartTemperatures.Series["Temperature"].Points.AddXY(0, 180);
            chartTemperatures.Series["Temperature"].Points.AddXY(10, 240);
            chartTemperatures.Series["Temperature"].Points.AddXY(40, 100);
            chartTemperatures.Series["Temperature"].Points.AddXY(60, 20);
            chartTemperatures.Series["Temperature"].Points.AddXY(80, 0);
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

            db.InsertBread(newBreadNameTextBox.Text);
            newBreadNameTextBox.Text = "";
            breads = db.GetBreads();
            UpdateBinding();
        }
    }
}
