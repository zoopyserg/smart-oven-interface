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
    public partial class ValveOpenCalibration : Form
    {
        public ValveOpenCalibration()
        {
            InitializeComponent();
            timeToFullyOpenVentilation.Value = Properties.Settings.Default.timeToFullyOpenVentilationValve;
        }

        private void saveCoefficientsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.timeToFullyOpenVentilationValve = Decimal.ToInt32(timeToFullyOpenVentilation.Value);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
