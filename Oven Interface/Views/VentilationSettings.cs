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
    public partial class VentilationSettings : Form
    {
        public VentilationSettings()
        {
            InitializeComponent();
            ventilationTimeToOpen.Value = Properties.Settings.Default.timeToFullyOpenVentilationValve;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.timeToFullyOpenVentilationValve = Decimal.ToInt32(ventilationTimeToOpen.Value);
        }
    }
}
