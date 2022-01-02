using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance
{
    class Database
    {

        private List<DailyData> data = null;
        private List<Transaction> transactions = null;
        private List<Ticker> tickers = null;

        // This method will properly connect to our database
        public void ConnectToDatabase()
        {
        }

        // This method will pull the data from database using specific queries for each set of information necessary
        public Database SelectDataFromDatabase(string dateFrom, string dateTo, string ticker)
        {
            return null; 
        }


        // The following Getters will be called by calculator to manipulate and from there will be called by graph
        public List<DailyData> GetData()
        {
            return this.data; 
        }

        public List<Transaction> GetTransactions()
        {
            return this.transactions; 
        }

        public List<Ticker> GetTickers()
        {
            return this.tickers; 
        }
        public class DailyData
        {
            public string tickerId;
            public string date;
            public string open;
            public string close; 
        }

        public class Transaction
        {
            public string tickerId;
            public string date;
            public string price;
            public string quantity; 
        }

        public class Ticker
        {
            public string tickerId;
            public string tickerName; 
        }
    }
}
