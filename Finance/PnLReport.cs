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
        Database database = null;
        Calculator calculator = null;
        public PnLReport()
        {
            InitializeComponent();
            database = new Database();
            calculator = new Calculator(database);
            displayTickers();
        }

        void recalculate()
        { 
            calculator.GetTotalPortfolioValue(dateTimePicker1.Value.ToString());
        }
        double recalculatePortfolioValue(DateTime date, String changePercent)
        {
            return 0;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            recalculate();
        }

        private void portfolioValueTxtBox_TextChanged(object sender, EventArgs e)
        {
            calculator.GetTotalPortfolioValue(dateTimePicker1.Value.ToString());
        }
        private List<Database.Ticker> PopulateTickersFake(){
            List<Database.Ticker> tickers = new List<Database.Ticker>();
            tickers.Add(new Database.Ticker("HMC","1"));
            tickers.Add(new Database.Ticker("NSANY", "2"));
            tickers.Add(new Database.Ticker("TM", "3"));
            tickers.Add(new Database.Ticker("TSLA", "4"));
            tickers.Add(new Database.Ticker("VOLCAR", "5"));
            return tickers;
        }

        private void tickersLbl_Click(object sender, EventArgs e)
        {
            displayTickers();
        }
        private void displayTickers()
        {
            List<Database.Ticker> tickers = PopulateTickersFake();
            Label[] labels = { tickerLbl1, label1, label2, label3, label4};
            int counter = 0;
            foreach (Database.Ticker ticker in tickers)
            {
                labels[counter++].Text = ticker.tickerName;
            }
        }
        private void displayQty()
        {
            List<Database.Ticker> tickers = PopulateTickersFake();
            Label[] labels = {qtyLbl1,qtyLbl2,qtyLbl3,qtyLbl4,qtyLbl5};
            int counter = 0;
            foreach (Database.Ticker ticker in tickers)
            {
                double quantity = calculator.getTotalQuantity(ticker.tickerName, dateTimePicker1.Value.ToString());
                labels[counter++].Text = quantity.ToString();
            }
       
        }

        private void rtuMoveTxtBox_TextChanged(object sender, EventArgs e)
        {
            recalculate();
        }

        private void PnLReport_Load(object sender, EventArgs e)
        {

        }

    }
}
