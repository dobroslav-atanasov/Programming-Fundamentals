using System;
using System.Collections.Generic;

namespace _02.VaporStore
{
    public class VaporStore
    {
        static void Main()
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double spend = 0;
            double remaining = currentBalance;

            var games = new Dictionary<String, double>();
            games.Add("OutFall 4", 39.99);
            games.Add("CS: OG", 15.99);
            games.Add("Zplinter Zell", 19.99);
            games.Add("Honored 2", 59.99);
            games.Add("RoverWatch", 29.99);
            games.Add("RoverWatch Origins Edition", 39.99);

            string input = Console.ReadLine();

            while (!input.Equals("Game Time"))
            {
                if (!games.ContainsKey(input))
                {
                    Console.WriteLine("Not Found");
                }
                else if (games.ContainsKey(input) && games[input] > remaining)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (games.ContainsKey(input) && games[input] <= remaining)
                {
                    Console.WriteLine($"Bought {input}");
                    spend += games[input];
                    remaining -= games[input];
                }

                if (remaining <= 0.00)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (remaining <= 0.00)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${spend:F2}. Remaining: ${remaining:F2}");
            }
        }
    }
}
