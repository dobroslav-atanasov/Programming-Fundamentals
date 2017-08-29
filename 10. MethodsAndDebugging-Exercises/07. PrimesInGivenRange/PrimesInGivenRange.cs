using System;
using System.Collections.Generic;

namespace _07.PrimesInGivenRange
{
    public class PrimesInGivenRange
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            if (start <= end)
            {
                List<int> list = FindPrimeNumber(start, end);
                Console.WriteLine(string.Join(", ", list));
            }
        }

        public static List<int> FindPrimeNumber(int start, int end)
        {
            List<int> list = new List<int>();
            if (start < 2)
            {
                start = 2;
            }
                        
            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    list.Add(i);
                }
            }

            return list;
        }
    }
}
