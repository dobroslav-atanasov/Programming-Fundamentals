using System;
using System.Linq;

namespace _03.FoldAndSum
{
    public class FoldAndSum
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = array.Length / 4;

            int[] first = new int[2 * k];
            int[] second = new int[2 * k];
            int[] sum = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                first[i] = array[k - 1 - i];
            }
            for (int i = 0; i < k; i++)
            {
                first[i + k] = array[array.Length - 1 - i];
            }
            for (int i = 0; i < second.Length; i++)
            {
                second[i] = array[k + i];
            }

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = first[i] + second[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
