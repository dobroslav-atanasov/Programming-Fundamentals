using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddFilter
{
    public class OddFilter
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            list = list.Where(x => x % 2 == 0).ToList();
            List<int> finalResult = list.Select(x => x > list.Average() ? ++x : --x).ToList();

            Console.WriteLine(string.Join(" ", finalResult));
        }
    }
}
