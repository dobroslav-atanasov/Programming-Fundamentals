using System;
using System.Linq;

namespace _08.MostFrequentNumber
{
    public class MostFrequentNumber
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 0;
            int position = 0;
            int bestCount = 0;
            int bestPosition = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        position = array[i];
                    }
                }

                if (count > bestCount)
                {
                    bestCount = count;
                    bestPosition = position;
                }

                count = 0;
            }

            Console.WriteLine(bestPosition);
        }
    }
}
