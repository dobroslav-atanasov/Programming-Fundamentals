using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Heists
{
    public class Heists
    {
        static void Main()
        {
            int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int priceJewels = prices[0];
            int priceGold = prices[1];

            string input = Console.ReadLine();
            long heistExpenses = 0;
            long totalEarnings = 0;

            while (!input.Equals("Jail Time"))
            {
                string[] inputParts = input.Split(' ').ToArray();
                char[] loots = inputParts[0].ToCharArray();
                heistExpenses += int.Parse(inputParts[1]);

                for (int i = 0; i < loots.Length; i++)
                {
                    if (loots[i].Equals('%'))
                    {
                        totalEarnings += priceJewels;
                    }
                    else if (loots[i].Equals('$'))
                    {
                        totalEarnings += priceGold;
                    }
                }

                input = Console.ReadLine();
            }

            if (totalEarnings >= heistExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings - heistExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {heistExpenses - totalEarnings}.");
            }
        }
    }
}
