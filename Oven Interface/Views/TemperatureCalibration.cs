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
    public partial class TemperatureCalibration : Form
    {
        public Dashboard form { get; set; }

        public TemperatureCalibration(Dashboard form)
        {
            this.form = form;
            InitializeComponent();

            sensorValueLabel.Text = this.form.CurrentSensorValue.ToString();
            temperatureLabel.Text = $"{ this.form.CurrentTemperature } C";
            coefficientA.Value = Properties.Settings.Default.temperatureCoefficientA;
            coefficientB.Value = Properties.Settings.Default.temperatureCoefficientB;
            coefficientC.Value = Properties.Settings.Default.temperatureCoefficientC;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveCoefficientsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.temperatureCoefficientA = coefficientA.Value;
            Properties.Settings.Default.temperatureCoefficientB = coefficientB.Value;
            Properties.Settings.Default.temperatureCoefficientC = coefficientC.Value;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
