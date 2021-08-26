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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ISerialConnection connection = GetConnection(this.label8);

            if (connection != null)
                using (var session = new ArduinoSession(connection))
                    PerformBasicTest(session, this.label9);
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
            ISerialConnection connection = GetConnection(this.label8);

            if (connection != null)
                using (var session = new ArduinoSession(connection))
                    TurnOn(session, this.label9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Turn Off 13th Pin
            ISerialConnection connection = GetConnection(this.label8);

            if (connection != null)
                using (var session = new ArduinoSession(connection))
                    TurnOff(session, this.label9);
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
    }
}
