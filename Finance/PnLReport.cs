using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance
{
    public partial class PnLReport : Form
    {
        public PnLReport()
        {
            InitializeComponent();
        }

        private void recalculateButton_Click(object sender, EventArgs e)
        {
            recalculate();
        }
        void recalculate()
        {
            double value = recalculatePortfolioValue(dateTimePicker1.Value, rtuMoveTxtBox.Text);
        }
        double recalculatePortfolioValue(DateTime date, String changePercent)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
