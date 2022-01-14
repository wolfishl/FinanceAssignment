using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Finance.Database;

namespace Finance
{
    class Calculator
    {
        private Database database;

        public Calculator(Database database)
        {
            this.database = database;
        }

        /*
         * This method takes the ticker code, gets the data for that ticker, and calculates the value for that ticker
         * @Hadassah, this method will require the quantity owned of that ticker and the current price, given the ticker code
         */
        public double GetPositionValue(String ticker, String date)
        {
            double quantity = getTotalQuantity(ticker, date);   
            List<DailyData> tickerData = database.GetData(ticker, date, date);
            return double.Parse(tickerData[0].close) * quantity;
        }

        /*
         * This method calculates the total value of the portfolio
         * @Hadassah, this method will need the ticker codes of all the tickers in the portfolio
         */
        public double GetTotalPortfolioValue(String date)
        {
            double totalValue = 0;
            List<Ticker> tickers = database.GetTickers();
            foreach(Ticker ticker in tickers)
            {
                totalValue += GetPositionValue(ticker.tickerId, date);
            }
            return totalValue;
        }

        /*
         * This method calculates the daily yield of a ticker
         */
        private double CalculateDailyYield(double closeToday, double closeYesterday)
        {
            return (closeToday / closeYesterday) -1;
        }

        /*
         * This method calculates the beta to RTU for the given ticker, based on the last 250 days
         * @Hadassah, this method will need the closing prices for the last n number of days for a ticker code
         */
        public double CalculateBetaRTU(String ticker, String date)
        {
            double multipliedSum = 0;
            double tickerSum = 0;
            double RTUSum = 0;
            double tickerSquareSum = 0;
            List<DailyData> tickerData = database.GetData(ticker, database.getBeginningDate(), date);
            List<DailyData> RTUData = database.GetData("RTU", database.getBeginningDate(), date);
            for (int i = 0; i < tickerData.Count;)
            {
                DailyData tickerYesterday = tickerData[i];
                DailyData RTUYesterday = RTUData[i];
                DailyData tickerToday = tickerData[++i];
                DailyData RTUToday = RTUData[i];
                double tickerYield = CalculateDailyYield(double.Parse(tickerToday.close), double.Parse(tickerYesterday.close));
                double RTUYield = CalculateDailyYield(double.Parse(RTUToday.close), double.Parse(RTUYesterday.close));
                multipliedSum += tickerYield * RTUYield;
                tickerSum += tickerYield;
                RTUSum += RTUYield;
                tickerSquareSum += tickerYield * tickerYield;
            }
            int numberOfDays = tickerData.Count;
            double beta = (numberOfDays * multipliedSum - tickerSum * RTUSum) / (numberOfDays * tickerSquareSum - tickerSum * tickerSum);
            return beta;
        }

        /*
         * This method calculates the correlation with RTU for a given ticker
         */
        public double CalculateCorrelation(String ticker, String date)
        {
            double multipliedSum = 0;
            double tickerSum = 0;
            double RTUSum = 0;
            double tickerSquareSum = 0;
            double RTUSquareSum = 0;
            List<DailyData> tickerData = database.GetData(ticker, database.getBeginningDate(), date);
            List<DailyData> RTUData = database.GetData("RTU", database.getBeginningDate(), date);
            for (int i = 0; i < tickerData.Count;)
            {
                DailyData tickerYesterday = tickerData[i];
                DailyData RTUYesterday = RTUData[i];
                DailyData tickerToday = tickerData[++i];
                DailyData RTUToday = RTUData[i];
                double tickerYield = CalculateDailyYield(double.Parse(tickerToday.close), double.Parse(tickerYesterday.close));
                double RTUYield = CalculateDailyYield(double.Parse(RTUToday.close), double.Parse(RTUYesterday.close));
                multipliedSum += tickerYield * RTUYield;
                tickerSum += tickerYield;
                RTUSum += RTUYield;
                tickerSquareSum += tickerYield * tickerYield;
                RTUSquareSum += RTUYield * RTUYield;
            }
            int numberOfDays = tickerData.Count;
            double numerator = numberOfDays * multipliedSum - tickerSum * RTUSum;
            double denominator = Math.Sqrt((numberOfDays * tickerSquareSum - tickerSum * tickerSum) * (numberOfDays * RTUSquareSum - RTUSum * RTUSum));
            double correlation = numerator / denominator;
            return correlation;
        }


        /*
         *This method calculates the predicted move for a given ticker based on a given RTU move 
         */
        public double CalculatePredictedMove(String ticker, double RTU, String date)
        {
            double predictedMove = CalculateBetaRTU(ticker, date) * RTU;


            return predictedMove;
        }

        /*
         * This method calculates the predicted PnL of a given ticker for a predictedMove
         */
        public double CalculatePredictedPnL(String ticker, double predictedMove, String date)
        {
            double PnL = predictedMove * GetPositionValue(ticker, date);
            return PnL;
        }

        /*
         * This method returns the total predicted PnL given a list of the predicted PnLs for each ticker
         */
        public double CalculateTotalPredictedPnL(double[] predictedPnLs)
        {
            double totalPnL = 0;
            foreach(double PnL in predictedPnLs)
            {
                totalPnL += PnL;
            }
            return totalPnL;
        }

        /*
         * This method calculates the trading PnL for a given ticker on a given date
         * @Hadassah, this method will require the Trade Quantity, Closing Price, and Trading Price for a specific ticker code on a given date
         */
        public List<double> CalculateTradingPnL(String ticker, String dateStart, String dateEnd)
        {
            List<double> tradingPnLs = new List<double>();
            List<DailyData> dailyData = database.GetData(ticker, dateStart, dateEnd);
            foreach (DailyData day in dailyData)
            {
                int tradeQuantity = 0;
                List<Transaction> transactions = database.GetTransactions(ticker, day.date, day.date);
                foreach(Transaction transaction in transactions)
                {
                    tradeQuantity += int.Parse(transaction.quantity);
                }
                tradingPnLs.Add(tradeQuantity * (double.Parse(day.close) - double.Parse(transactions[0].price)));
            }

            return tradingPnLs;
        }

        /*
         * This method will return the total quantity of a given ticker on a given date
         * 
         */
        public double getTotalQuantity(String ticker, String date)
        {
            double quantity = 0;
            List<Transaction> transactions = database.GetTransactions(ticker, database.getBeginningDate(), date);
            foreach (Transaction transaction in transactions)
            {
                quantity += Double.Parse(transaction.quantity);
            }
            return quantity;
        }

        /*
         * This method calculates the positional PnL of a given ticker on a given date
         * @Hadassah, this method will need the prior closing price of the ticker
         */
        public double CalculatePositionalPnL(String ticker, String date)
        {
            DateTime today = DateTime.Parse(date);
            DateTime yesterday = today.AddDays(-1);
            List<DailyData> data = database.GetData(ticker, yesterday.ToString(), date);
            return getTotalQuantity(ticker, date) * (double.Parse(data[0].close) - double.Parse(data[1].close));
        }

        /*
         * This method returns the Total Daily PnL for a given ticker on a given date
         */
        public double CalculateTotalDailyPnL(String ticker, String date)
        {
            List<double> tradingPnl = CalculateTradingPnL(ticker, date, date);
            return  tradingPnl[0] + CalculatePositionalPnL(ticker, date);
        }

        /*
         * This method returns the cumulative PnL for a given ticker on a given date
         */
        public double CalculateCumulativePnL(String ticker, String date)
        {
            double PnL;
            if (date == database.getBeginningDate())
            {
                PnL = CalculateTotalDailyPnL(ticker, date);
            }
            else
            {
                DateTime today = DateTime.Parse(date);
                DateTime yesterday = today.AddDays(-1);
                PnL = CalculateCumulativePnL(ticker, yesterday.ToString()) + CalculateTotalDailyPnL(ticker, date);
            }
            return PnL;
        }
    }
}
