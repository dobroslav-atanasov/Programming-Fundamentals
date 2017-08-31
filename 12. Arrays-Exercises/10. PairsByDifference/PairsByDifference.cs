using System;
using System.Linq;

namespace _10.PairsByDifference
{
    public class PairsByDifference
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] - array[j] == n)
                    {
                        count++;
                    }        
                }
            }

            Console.WriteLine(count);
        }
    }
}
