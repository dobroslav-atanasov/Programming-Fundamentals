using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SortTimes
{
    public class SortTimes
    {
        static void Main()
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();

            list.Sort();

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
