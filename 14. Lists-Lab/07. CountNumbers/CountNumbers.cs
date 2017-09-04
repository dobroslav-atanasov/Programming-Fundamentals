using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CountNumbers
{
    public class CountNumbers
    {
        static void Main()
        {
            SortedDictionary<int, int> nums = new SortedDictionary<int, int>();
            List<int> list = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (!nums.ContainsKey(list[i]))
                {
                    nums[list[i]] = 1;
                }
                else
                {
                    nums[list[i]]++;
                }
            }

            foreach (KeyValuePair<int, int> num in nums)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
