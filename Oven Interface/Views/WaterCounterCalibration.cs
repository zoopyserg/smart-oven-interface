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
    public partial class WaterCounterCalibration : Form
    {
        public WaterCounterCalibration()
        {
            InitializeComponent();
            waterClicksPerLiter.Value = Properties.Settings.Default.waterClicksPerLiter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.waterClicksPerLiter = Decimal.ToInt32(waterClicksPerLiter.Value);
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
