using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oven_Interface.Views
{
    public partial class PinTesting : Form
    {
        public ArduinoAccess ArduinoConnection { get; set; }
        public PinTesting(ArduinoAccess arduinoConnection)
        {
            InitializeComponent();
            this.ArduinoConnection = arduinoConnection;

            if (arduinoConnection.AvailablePins.Contains(1))
            {
                turnOnPin1Button.Enabled = true;
                turnOffPin1Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(2))
            {
                turnOnPin2Button.Enabled = true;
                turnOffPin2Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(3))
            {
                turnOnPin3Button.Enabled = true;
                turnOffPin3Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(4))
            {
                turnOnPin4Button.Enabled = true;
                turnOffPin4Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(5))
            {
                turnOnPin5Button.Enabled = true;
                turnOffPin5Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(6))
            {
                turnOnPin6Button.Enabled = true;
                turnOffPin6Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(7))
            {
                turnOnPin7Button.Enabled = true;
                turnOffPin7Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(8))
            {
                turnOnPin8Button.Enabled = true;
                turnOffPin8Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(9))
            {
                turnOnPin9Button.Enabled = true;
                turnOffPin9Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(10))
            {
                turnOnPin10Button.Enabled = true;
                turnOffPin10Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(11))
            {
                turnOnPin11Button.Enabled = true;
                turnOffPin11Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(12))
            {
                turnOnPin12Button.Enabled = true;
                turnOffPin12Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(13))
            {
                turnOnPin13Button.Enabled = true;
                turnOffPin13Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(14))
            {
                turnOnPin14Button.Enabled = true;
                turnOffPin14Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(15))
            {
                turnOnPin15Button.Enabled = true;
                turnOffPin15Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(16))
            {
                turnOnPin16Button.Enabled = true;
                turnOffPin16Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(17))
            {
                turnOnPin17Button.Enabled = true;
                turnOffPin17Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(18))
            {
                turnOnPin18Button.Enabled = true;
                turnOffPin18Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(19))
            {
                turnOnPin19Button.Enabled = true;
                turnOffPin19Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(20))
            {
                turnOnPin20Button.Enabled = true;
                turnOffPin20Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(21))
            {
                turnOnPin21Button.Enabled = true;
                turnOffPin21Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(22))
            {
                turnOnPin22Button.Enabled = true;
                turnOffPin22Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(23))
            {
                turnOnPin23Button.Enabled = true;
                turnOffPin23Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(24))
            {
                turnOnPin24Button.Enabled = true;
                turnOffPin24Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(25))
            {
                turnOnPin25Button.Enabled = true;
                turnOffPin25Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(26))
            {
                turnOnPin26Button.Enabled = true;
                turnOffPin26Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Contains(27))
            {
                turnOnPin27Button.Enabled = true;
                turnOffPin27Button.Enabled = true;
            }

            if (arduinoConnection.AvailablePins.Count > 0)
            {
                turnOnAllPinsButton.Enabled = true;
                turnOffAllPinsButton.Enabled = true;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(1, Properties.Settings.Default.relayBoardNumber);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(2, Properties.Settings.Default.relayBoardNumber);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(3, Properties.Settings.Default.relayBoardNumber);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(4, Properties.Settings.Default.relayBoardNumber);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(5, Properties.Settings.Default.relayBoardNumber);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(6, Properties.Settings.Default.relayBoardNumber);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(7, Properties.Settings.Default.relayBoardNumber);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(8, Properties.Settings.Default.relayBoardNumber);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(9, Properties.Settings.Default.relayBoardNumber);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(10, Properties.Settings.Default.relayBoardNumber);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(11, Properties.Settings.Default.relayBoardNumber);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(12, Properties.Settings.Default.relayBoardNumber);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(13, Properties.Settings.Default.relayBoardNumber);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(14, Properties.Settings.Default.relayBoardNumber);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(15, Properties.Settings.Default.relayBoardNumber);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(16, Properties.Settings.Default.relayBoardNumber);
        }

        private void turnOnTestDiodButton_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(17, Properties.Settings.Default.relayBoardNumber);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(18, Properties.Settings.Default.relayBoardNumber);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(19, Properties.Settings.Default.relayBoardNumber);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(20, Properties.Settings.Default.relayBoardNumber);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(21, Properties.Settings.Default.relayBoardNumber);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(22, Properties.Settings.Default.relayBoardNumber);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(23, Properties.Settings.Default.relayBoardNumber);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(24, Properties.Settings.Default.relayBoardNumber);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(25, Properties.Settings.Default.relayBoardNumber);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(26, Properties.Settings.Default.relayBoardNumber);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(27, Properties.Settings.Default.relayBoardNumber);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnAllPins();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(1, Properties.Settings.Default.relayBoardNumber);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(2, Properties.Settings.Default.relayBoardNumber);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(3, Properties.Settings.Default.relayBoardNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(4, Properties.Settings.Default.relayBoardNumber);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(5, Properties.Settings.Default.relayBoardNumber);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(6, Properties.Settings.Default.relayBoardNumber);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(7, Properties.Settings.Default.relayBoardNumber);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(8, Properties.Settings.Default.relayBoardNumber);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(9, Properties.Settings.Default.relayBoardNumber);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(10, Properties.Settings.Default.relayBoardNumber);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(11, Properties.Settings.Default.relayBoardNumber);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(12, Properties.Settings.Default.relayBoardNumber);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(13, Properties.Settings.Default.relayBoardNumber);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(14, Properties.Settings.Default.relayBoardNumber);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(15, Properties.Settings.Default.relayBoardNumber);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(16, Properties.Settings.Default.relayBoardNumber);
        }

        private void turnOffTestDiodButton_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(17, Properties.Settings.Default.relayBoardNumber);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(18, Properties.Settings.Default.relayBoardNumber);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(19, Properties.Settings.Default.relayBoardNumber);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(20, Properties.Settings.Default.relayBoardNumber);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(21, Properties.Settings.Default.relayBoardNumber);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(22, Properties.Settings.Default.relayBoardNumber);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(23, Properties.Settings.Default.relayBoardNumber);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(24, Properties.Settings.Default.relayBoardNumber);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(25, Properties.Settings.Default.relayBoardNumber);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(26, Properties.Settings.Default.relayBoardNumber);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(27, Properties.Settings.Default.relayBoardNumber);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffAllPins();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(13, Properties.Settings.Default.temperatureSensorBoardNumber);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(13, Properties.Settings.Default.temperatureSensorBoardNumber);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(13, Properties.Settings.Default.waterCounterBoardNumber);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(13, Properties.Settings.Default.waterCounterBoardNumber);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(13, Properties.Settings.Default.temperatureSensorBoardNumber);
        }
    }
}
