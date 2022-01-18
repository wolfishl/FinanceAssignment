using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance
{
    class Database
    {
        private readonly String BEGINNING_DATE = "2021-01-01";
        private List<DailyData> data = null;
        private List<Transaction> transactions = null;
        private List<Ticker> tickers = null;

        public String getBeginningDate()
        {
            return this.BEGINNING_DATE;
        }

        // This method will properly connect to our database
        public void ConnectToDatabaseAndPullData() {

            SqlConnection sqlConnection = null;
            string connectionString = "Server=LAPTOP-HF23KPQS\\SQLEXPRESS02;Database=PortfolioData;Trusted_Connection=True;";
            string queryStringData = "SELECT * FROM dbo.TS_Data";
            string queryStringTicker = "SELECT * FROM dbo.TS_Tickers";
            string queryStringTransaction = "SELECT * FROM dbo.TS_TickerTransactions";

            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                SqlCommand dataCmd = new SqlCommand(queryStringData, sqlConnection);
                dataCmd.ExecuteNonQuery(); 
                SqlDataAdapter dataAdapter = new SqlDataAdapter(dataCmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "DailyData");
                data = PopulateData(dataSet);

                SqlCommand transactionCmd = new SqlCommand(queryStringTransaction, sqlConnection);
                transactionCmd.ExecuteNonQuery();
                SqlDataAdapter transactionAdapter = new SqlDataAdapter(transactionCmd);
                DataSet transactionSet = new DataSet();
                transactionAdapter.Fill(transactionSet, "Transactions");
                transactions = PopulateTransactions(transactionSet);

                SqlCommand tickerCmd = new SqlCommand(queryStringTicker, sqlConnection);
                tickerCmd.ExecuteNonQuery();
                SqlDataAdapter tickerAdapter = new SqlDataAdapter(tickerCmd);
                DataSet tickerSet = new DataSet();
                tickerAdapter.Fill(tickerSet, "Tickers");
                tickers = PopulateTickers(tickerSet);

                MessageBox.Show("done"); 

            } catch (Exception exc)
                {
                MessageBox.Show(exc.Message); 
                }
            }

        public List<Ticker> PopulateTickers(DataSet tickerSet)
        {
            List<Ticker> tickers = new List<Ticker>();
            int numRows = tickerSet.Tables[0].Rows.Count;
            var table = tickerSet.Tables[0];
            for (int row = 0; row < numRows; row++)
            {
                Ticker ticker = new Ticker("","");
                ticker.tickerId = table.Rows[row][0].ToString();
                ticker.tickerName = table.Rows[row][1].ToString();
                tickers.Add(ticker);
            }
            return tickers;
        }

        public List<Transaction> PopulateTransactions(DataSet transactionSet)
        {
            List<Transaction> transactions = new List<Transaction>();
            int numRows = transactionSet.Tables[0].Rows.Count;
            var table = transactionSet.Tables[0];
            for (int row = 0; row < numRows; row++)
            {
                Transaction transaction = new Transaction();
                transaction.tickerId = table.Rows[row][1].ToString();
                transaction.date = table.Rows[row][2].ToString();
                transaction.price = Convert.ToDouble(table.Rows[row][3]);
                transaction.quantity = Convert.ToInt32(table.Rows[row][4]);
                transactions.Add(transaction);
            }
            return transactions;
        }

        private List<DailyData> PopulateData(DataSet dataSet)
        {
            List<DailyData> data = new List<DailyData>(); 
            int numRows = dataSet.Tables[0].Rows.Count;
            var table = dataSet.Tables[0]; 
            for (int row = 0; row < numRows; row++)
            {
                DailyData dailyData = new DailyData();
                dailyData.tickerId = table.Rows[row][1].ToString(); 
                dailyData.date = table.Rows[row][2].ToString(); 
                dailyData.open = Convert.ToDouble(table.Rows[row][3]); 
                dailyData.close = Convert.ToDouble(table.Rows[row][4]);
                data.Add(dailyData); 
            }
            return data; 
        }


        // The following Getters will be called by calculator to manipulate and from there will be called by graph

        /**
         * Return data for specified ticker in specified date range
         */
        public List<DailyData> GetData(string tickerId, string dateFrom, string dateTo)
        {
            return this.data; 
        }

        /** 
         * Returns transactions in specified date range
         */
        public List<Transaction> GetTransactions(string tickerId, string dateFrom, string dateTo)
        {
            return this.transactions; 
        }

        /** 
         * Returns all tickers
         */
        public List<Ticker> GetTickers()
        {
            return this.tickers; 
        }
        public class DailyData
        {
            public string tickerId;
            public string date;
            public double open;
            public double close; 
        }

        public class Transaction
        {
            public string tickerId;
            public string date;
            public double price;
            public int quantity;
            public Transaction(String id, String tDate, double tPrice, int tQty)
            {
                tickerId = id;
                date = tDate;
                price = tPrice;
                quantity = tQty;
            }
        }

        public class Ticker
        {
            public string tickerId;
            public string tickerName;
            public Ticker(String ticker, String id)
            {
                tickerId = id;
                tickerName = ticker;
            }
        }
    }
}
