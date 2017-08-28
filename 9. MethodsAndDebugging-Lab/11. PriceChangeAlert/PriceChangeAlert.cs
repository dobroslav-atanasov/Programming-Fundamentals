using System;

namespace _11.PriceChangeAlert
{
    public class PriceChangeAlert
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal threshold = decimal.Parse(Console.ReadLine());
            decimal lastPrice = decimal.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                decimal currentPrice = decimal.Parse(Console.ReadLine());
                decimal diff = ProcentDifference(lastPrice, currentPrice);
                bool isSignificantDifference = isDiff(diff, threshold);

                string message = Get(currentPrice, lastPrice, diff, isSignificantDifference);
                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }

        private static string Get(decimal currentPrice, decimal lastPrice, decimal percentDiff, bool etherTrueOrFalse)
        {
            string output = "";
            if (percentDiff == 0)
            {
                output = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!etherTrueOrFalse)
            {
                output = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, percentDiff * 100);
            }
            else if (etherTrueOrFalse && (percentDiff > 0))
            {
                output = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, percentDiff * 100);
            }
            else if (etherTrueOrFalse && (percentDiff < 0))
            {
                output = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, percentDiff * 100);
            }                
            return output;
        }

        private static bool isDiff(decimal diff, decimal threshold)
        {
            if (Math.Abs(diff) >= threshold)
            {
                return true;
            }
            return false;
        }

        private static decimal ProcentDifference(decimal lastPrice, decimal currentPrice)
        {
            decimal diff = (currentPrice - lastPrice) / lastPrice;
            return diff;
        }
    }
}
