using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MaxSequenceOfEqualElements
{
    public class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int start = 0;
            int length = 1;
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[i - 1])
                {
                    length++;                    
                }
                else
                {
                    length = 1;
                    start = i;
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestStart = start;
                }
            }

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
