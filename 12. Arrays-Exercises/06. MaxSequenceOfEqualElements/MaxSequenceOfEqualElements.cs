using System;
using System.Linq;

namespace _06.MaxSequenceOfEqualElements
{
    public class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int start = 0;
            int length = 1;
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    length++;
                }
                else
                {
                    start = i;
                    length = 1;
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestStart = start;
                }
            }

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
