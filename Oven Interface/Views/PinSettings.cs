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
    public partial class PinSettings : Form
    {
        public PinSettings()
        {
            InitializeComponent();

            thermalSensorChannel.Value = Properties.Settings.Default.channelTemperatureSensor;
            thermalRelayPin.Value = Properties.Settings.Default.pinTemperatureRelay;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveCoefficientsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.channelTemperatureSensor = Decimal.ToInt32(thermalSensorChannel.Value);
            Properties.Settings.Default.pinTemperatureRelay = Decimal.ToInt32(thermalRelayPin.Value);
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
