using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.UpgradedMatcher
{
    public class UpgradedMatcher
    {
        static void Main()
        {
            string[] name = Console.ReadLine().Split(' ').ToArray();
            long[] quantity = new long[name.Length];
            long[] quantityParts = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            for (int i = 0; i < quantityParts.Length; i++)
            {
                quantity[i] = quantityParts[i];
            }

            decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            string input = Console.ReadLine();

            while (input != "done")
            {
                string[] inputParts = input.Split(' ').ToArray();
                string nameOfProduct = inputParts[0];
                long ordered = long.Parse(inputParts[1]);

                int index = Array.LastIndexOf(name, nameOfProduct);
                if (quantity[index] < ordered)
                {
                    Console.WriteLine($"We do not have enough {name[index]}");
                }
                else
                {
                    Console.WriteLine($"{name[index]} x {ordered} costs {(ordered * price[index]):F2}");
                    quantity[index] -= ordered;
                }

                input = Console.ReadLine();
            }
        }
    }
}
