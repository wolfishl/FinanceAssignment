using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void ConnectToDatabase()
        {
        }

        // This method will pull all the data from database using specific queries for each set of information necessary
        public Database SelectDataFromDatabase()
        {
            return null; 
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
