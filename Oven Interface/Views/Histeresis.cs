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
    public partial class Histeresis : Form
    {
        public Histeresis()
        {
            InitializeComponent();

            allowChangeTempAfter.Value = Properties.Settings.Default.canChangeTempsAgainAfter;
            turnOffRelaysAfter.Value = Properties.Settings.Default.turnOffTempOperationsAfter;
            howOftenToCheckSensors.Value = Properties.Settings.Default.howOftenToCheckSensors;
        }

        private void saveCoefficientsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.canChangeTempsAgainAfter = Decimal.ToInt32(allowChangeTempAfter.Value);
            Properties.Settings.Default.turnOffTempOperationsAfter = Decimal.ToInt32(turnOffRelaysAfter.Value);
            Properties.Settings.Default.howOftenToCheckSensors = Decimal.ToInt32(howOftenToCheckSensors.Value);
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
