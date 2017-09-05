using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.LongestIncreasingSubsequence
{
    public class LongestIncreasingSubsequence
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] length = new int[list.Count];
            int[] previus = new int[list.Count];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < list.Count; i++)
            {
                length[i] = 1;
                previus[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (list[j] < list[i] && length[j] + 1 > length[i])
                    {
                        length[i] = length[j] + 1;
                        previus[i] = j;
                    }
                }

                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }

            List<int> result = new List<int>();

            while (lastIndex != -1)
            {
                result.Add(list[lastIndex]);
                lastIndex = previus[lastIndex];
            }

            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
