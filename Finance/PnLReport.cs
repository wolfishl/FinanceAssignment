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

        private void displayDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void recalculateButton_Click(object sender, EventArgs e)
        {
            recalculate();
        }
        void recalculate()
        {
            double value = recalculate(displayDate.Value, textBoxRTU.Text);
            totalPortfolioValue.Text = value.ToString();

        }
        double recalculate(DateTime date, String changePercent)
        {
            //return GetTotalPortfolioValue.value;
        }

        private void totalPortfolioValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRTU_TextChanged(object sender, EventArgs e)
        {
            recalculate();
        }
    }
}
