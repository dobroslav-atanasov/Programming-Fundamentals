using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SupermarketDatabase
{
    public class SupermarketDatabase
    {
        static void Main()
        {
            Dictionary<string, decimal[]> database = new Dictionary<string, decimal[]>();
            string input = Console.ReadLine();

            while (input != "stocked")
            {
                string[] inputParts = input.Split(' ').ToArray();
                string product = inputParts[0];
                decimal price = decimal.Parse(inputParts[1]);
                int quantity = int.Parse(inputParts[2]);

                if (!database.ContainsKey(product))
                {
                    database[product] = new decimal[3];
                }
                database[product][0] = price;
                database[product][1] += quantity;
                database[product][2] = database[product][0] * database[product][1];

                input = Console.ReadLine();
            }

            decimal sum = 0;
            foreach (var product in database)
            {
                sum += product.Value[2];
                Console.WriteLine($"{product.Key}: ${product.Value[0]} * {product.Value[1]} = ${product.Value[2]:F2}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${sum:F2}");
        }
    }
}
