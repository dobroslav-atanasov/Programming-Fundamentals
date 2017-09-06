using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FoldAndSum
{
    public class FoldAndSum
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int k = list.Count / 4;

            var left = list.Take(k).Reverse().ToList();
            var right = list.Skip(list.Count - k).Take(k).Reverse().ToList();

            var first = left.Concat(right).ToList();
            var second = list.Skip(k).Take(2 * k).ToList();

            var sum = first.Select((x, index) => x + second[index]).ToList();

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
