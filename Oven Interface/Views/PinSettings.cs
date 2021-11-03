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

            thermalSensorChannel.Value = Properties.Settings.Default.channelTemperatureSensor;
            thermalIncreaseRelayPin.Value = Properties.Settings.Default.temperatureUpPin;
            thermalDecreaseRelayPin.Value = Properties.Settings.Default.temperatureDownPin;
            lightsRelayPin.Value = Properties.Settings.Default.lightsPin;
            powerplantRelayPin.Value = Properties.Settings.Default.powerplantPin;
            ventilationOpenRelayPin.Value = Properties.Settings.Default.openVentilationPin;
            ventilationCloseRelayPin.Value = Properties.Settings.Default.closeVentilationPin;
            waterValveOpenRelayPin.Value = Properties.Settings.Default.waterSolenoidPin;

            waterCounterPin.Value = Properties.Settings.Default.waterCounterPin;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveCoefficientsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.channelTemperatureSensor = Decimal.ToInt32(thermalSensorChannel.Value);
            Properties.Settings.Default.temperatureUpPin = Decimal.ToInt32(thermalIncreaseRelayPin.Value);
            Properties.Settings.Default.temperatureDownPin = Decimal.ToInt32(thermalDecreaseRelayPin.Value);
            Properties.Settings.Default.lightsPin = Decimal.ToInt32(lightsRelayPin.Value);
            Properties.Settings.Default.powerplantPin = Decimal.ToInt32(powerplantRelayPin.Value);
            Properties.Settings.Default.openVentilationPin = Decimal.ToInt32(ventilationOpenRelayPin.Value);
            Properties.Settings.Default.closeVentilationPin = Decimal.ToInt32(ventilationCloseRelayPin.Value);
            Properties.Settings.Default.waterSolenoidPin = Decimal.ToInt32(waterValveOpenRelayPin.Value);
            Properties.Settings.Default.waterCounterPin = Decimal.ToInt32(waterCounterPin.Value);
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
