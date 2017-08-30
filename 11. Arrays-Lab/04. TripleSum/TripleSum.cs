using System;
using System.Linq;

namespace _04.TripleSum
{
    public class TripleSum
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isValid = false;

            for (int a = 0; a < array.Length; a++)
            {
                for (int b = a + 1; b < array.Length; b++)
                {
                    int first = array[a];
                    int second = array[b];
                    int sum = first + second;

                    if (array.Contains(sum))
                    {
                        Console.WriteLine($"{array[a]} + {array[b]} == {sum}");
                        isValid = true;
                    }
                }
            }

            if (!isValid)
            {
                Console.WriteLine("No");
            }
        }
    }
}
