using System;
using System.Linq;

namespace _04.SieveOfEratosthenes
{
    public class SieveOfEratosthenes
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            bool[] array = new bool[n + 1];
            for (int i = 0; i <= n; i++)
            {
                array[i] = true;
            }

            array[0] = false;
            array[1] = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == true)
                {
                    for (int j = 2; (j * i) <= n; j++)
                    {
                        array[j * i] = false;
                    }
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (array[i] == true)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
