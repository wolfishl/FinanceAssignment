using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance
{
    class Calculator
    {

        /*
         * This method takes the ticker code, gets the data for that ticker, and calculates the value for that ticker
         * @Hadassah, this method will require the quantity owned of that ticker and the current price, given the ticker code
         */
        public double GetPositionValue(String ticker)
        {
            double value = 0;

            //TODO

            return value;
        }

        /*
         * This method calculates the total value of the portfolio
         * @Hadassah, this method will need the ticker codes of all the tickers in the portfolio
         */
        public double GetTotalPortfolioValue()
        {
            double value = 0;

            //TODO

            return value;
        }

        /*
         * This method calculates the daily yield of a ticker
         */
        private double CalculateDailyYield(double closeToday, double closeYesterday)
        {
            double yield = 0;

            //TODO

            return yield;
        }

        /*
         * This method calculates the beta to RTU for the given ticker, based on the last 250 days
         * @Hadassah, this method will need the closing prices for the last n number of days for a ticker code
         */
        public double CalculateBetaRTU(String Ticker)
        {
            double beta = 0;

            //TODO

            return beta;
        }

        /*
         * This method calculates the correlation with RTU for a given ticker
         */
        public double CalculateCorrelation(String Ticker)
        {
            double correlation = 0;

            //TODO

            return correlation;
        }


        /*
         *This method calculates the predicted move for a given ticker based on a given RTU move 
         */
        public double CalculatePredictedMove(String ticker, double RTU)
        {
            double predictedMove = 0;

            //TODO

            return predictedMove;
        }

        /*
         * This method calculates the predicted PnL of a given ticker for a predictedMove
         */
        public double CalculatePredictedPnL(String ticker, double predictedMove)
        {
            double PnL = 0;

            //TODO

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
        public double CalculateTradingPnL(String ticker, DateTime date)
        {
            double tradingPnL = 0;

            //TODO

            return tradingPnL;
        }

        /*
         * This method will return the total quantity of a given ticker on a given date
         * @Hadassah, this method will need the total quantity of the ticker before the trade
         */
        public double getTotalQuantity(String ticker, DateTime date)
        {
            double quantity = 0;

            //TODO

            return quantity;
        }

        /*
         * This method calculates the positional PnL of a given ticker on a given date
         * @Hadassah, this method will need the prior closing price of the ticker
         */
        public double CalculatePositionalPnL(String ticker, DateTime date)
        {
            double PnL = 0;

            //TODO

            return PnL;
        }

        /*
         * This method returns the Total Daily PnL for a given ticker on a given date
         */
        public double CalculateTotalDailyPnL(String ticker, DateTime date)
        {
            return CalculateTradingPnL(ticker, date) + CalculatePositionalPnL(ticker, date);
        }

        /*
         * This method returns the cumulative PnL for a given ticker on a given date
         */
        public double CalculateCumulativePnL(String ticker, DateTime date, double priorCumulativePnL)
        {
            return priorCumulativePnL + CalculateTotalDailyPnL(ticker, date);
        }
    }
}
