using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    public class CountRealNumbers
    {
        static void Main()
        {
            var dictionary = new SortedDictionary<double, int>();
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            foreach (var num in nums)
            {
                if (!dictionary.ContainsKey(num))
                {
                    dictionary[num] = 0;
                }

                dictionary[num]++;
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
