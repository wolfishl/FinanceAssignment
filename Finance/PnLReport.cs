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
            displayQty();
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
        private List<Database.Transaction> PopulateTransactionsFake()
        {
            List<Database.Transaction> transactions = new List<Database.Transaction>();
            transactions.Add(new Database.Transaction("1", "01/01/2022", 200.05, 10));
            transactions.Add(new Database.Transaction("2", "01/01/2022", 128.00, 15));
            transactions.Add(new Database.Transaction("3", "01/01/2022", 46.76, 20));
            transactions.Add(new Database.Transaction("4", "01/01/2022", 1050.50, 4));
            transactions.Add(new Database.Transaction("5", "01/01/2022", 368.43, 6));
            return transactions;
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

        private void quantityLbl_Click(object sender, EventArgs e)
        {
            displayQty();
        }

        private void valueLbl_Click(object sender, EventArgs e)
        {
            diplayValues();
        }

        private void diplayValues()
        {
            List<Database.Ticker> tickers = PopulateTickersFake();
            List<Database.Transaction> transactions = PopulateTransactionsFake();
            Label[] labels = { valueLbl1, valueLbl2, valueLbl3, valueLbl4, valueLbl5};
            int counter = 0;
            foreach (Database.Ticker ticker in tickers)
            {
                double values = calculator.GetPositionValue(ticker.tickerName, dateTimePicker1.ToString());
                labels[counter++].Text = values.ToString();
            }
        }

        private void betaLabel_Click(object sender, EventArgs e)
        {
            displayBeta();
        }
        private void displayBeta()
        {
            List<Database.Ticker> tickers = PopulateTickersFake();
            List<Database.Transaction> transactions = PopulateTransactionsFake();
            Label[] labels = { betaLbl1, betaLbl2, betaLbl3, betaLbl4, betaLbl5 };
            int counter = 0;
            foreach (Database.Ticker ticker in tickers)
            {
                double values = calculator.CalculateBetaRTU(ticker.tickerName, dateTimePicker1.ToString());
                labels[counter++].Text = values.ToString();
            }
        }

        private void correlationLabel_Click(object sender, EventArgs e)
        {
            displayCorrelation();
        }
        private void displayCorrelation()
        {
            List<Database.Ticker> tickers = PopulateTickersFake();
            List<Database.Transaction> transactions = PopulateTransactionsFake();
            Label[] labels = { corrLbl1, corrLbl2, corrLbl3, corrLbl4, corrLbl5 };
            int counter = 0;
            foreach (Database.Ticker ticker in tickers)
            {
                double values = calculator.CalculateCorrelation(ticker.tickerName, dateTimePicker1.ToString());
                labels[counter++].Text = values.ToString();
            }
        }

        private void predictedMoveLbl_Click(object sender, EventArgs e)
        {
            calculatePredictedMove();
        }
        private void calculatePredictedMove()
        {
            double RTU = Convert.ToDouble(rtuMoveTxtBox.Text);
            List<Database.Ticker> tickers = PopulateTickersFake();
            List<Database.Transaction> transactions = PopulateTransactionsFake();
            Label[] labels = { predMovLbl1, predMoveLbl2, predMoveLbl3, predMoveLbl4, predMoveLbl5 };
            int counter = 0;
            foreach (Database.Ticker ticker in tickers)
            {
                double values = calculator.CalculatePredictedMove(ticker.tickerName, RTU, dateTimePicker1.ToString());
                labels[counter++].Text = values.ToString();
            }
        }

        private void PnLLabel_Click(object sender, EventArgs e)
        {
            calculatePnL();

        }
        private void calculatePnL()
        {
            List<Database.Ticker> tickers = PopulateTickersFake();
            List<Database.Transaction> transactions = PopulateTransactionsFake();
            Label[] labels = { betaLbl1, betaLbl2, betaLbl3, betaLbl4, betaLbl5 };
            int counter = 0;
            foreach (Database.Ticker ticker in tickers)
            {
                double values = calculator.CalculateTotalDailyPnL(ticker.tickerName, dateTimePicker1.ToString());
                labels[counter++].Text = values.ToString();
            }
        }

        private void predictedTotalPnL_TextChanged(object sender, EventArgs e)
        {
            calculator.CalculateTotalPredictedPnL();
        }
    }
}
