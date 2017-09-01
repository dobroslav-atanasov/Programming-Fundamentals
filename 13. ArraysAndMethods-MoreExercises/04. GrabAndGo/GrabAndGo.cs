using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GrabAndGo
{
    public class GrabAndGo
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            int lastIndex = Array.LastIndexOf(array, num);
            long sum = 0;

            if (lastIndex > 0)
            {
                for (int i = 0; i < lastIndex; i++)
                {
                    sum += array[i];
                }

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }

        }
    }
}
