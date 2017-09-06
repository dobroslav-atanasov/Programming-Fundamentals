using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest3Numbers
{
    public class Largest3Numbers
    {
        static void Main()
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            List<double> result = nums.OrderByDescending(x => x).Take(3).ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
