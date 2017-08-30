using System;
using System.Linq;

namespace _07.SumArrays
{
    public class SumArrays
    {
        static void Main()
        {
            int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sum = new int[Math.Max(first.Length, second.Length)];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = first[i % first.Length] + second[i % second.Length];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
