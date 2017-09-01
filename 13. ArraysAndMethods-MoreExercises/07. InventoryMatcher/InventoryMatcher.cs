using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.InventoryMatcher
{
    public class InventoryMatcher
    {
        static void Main()
        {
            string[] name = Console.ReadLine().Split(' ').ToArray();
            long[] quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            string input = Console.ReadLine();

            while (input != "done")
            {
                int index = Array.LastIndexOf(name, input);

                Console.WriteLine($"{name[index]} costs: {price[index]}; Available quantity: {quantity[index]}");

                input = Console.ReadLine();
            }
        }
    }
}
