using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void button31_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(6);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(7);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(8);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(9);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(10);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(11);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(12);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(13);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(14);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(15);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(16);
        }

        private void turnOnTestDiodButton_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(17);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(18);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(19);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(20);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(21);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(22);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(23);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(24);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(25);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(26);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOnPin(27);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 28; i++)
            {
                this.ArduinoConnection.TurnOnPin(i);
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(5);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(6);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(7);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(8);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(9);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(10);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(11);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(12);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(13);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(14);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(15);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(16);
        }

        private void turnOffTestDiodButton_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(17);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(18);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(19);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(20);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(21);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(22);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(23);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(24);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(25);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(26);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            this.ArduinoConnection.TurnOffPin(27);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 28; i++)
            {
                this.ArduinoConnection.TurnOffPin(i);
            }
        }
    }
}
