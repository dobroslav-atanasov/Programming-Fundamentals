using System;
using System.Linq;

namespace _09.ExtractMiddleElements
{
    public class ExtractMiddleElements
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (array.Length == 1)
            {
                Console.WriteLine($"{{ {array[0]} }}");
            }
            else if (array.Length % 2 == 0)
            {
                int[] result = new int[2];
                result[0] = array[array.Length / 2 - 1];
                result[1] = array[array.Length / 2];
                Console.WriteLine($"{{ {result[0]}, {result[1]} }}");
            }
            else
            {
                int[] result = new int[3];
                result[0] = array[array.Length / 2 - 1];
                result[1] = array[array.Length / 2];
                result[2] = array[array.Length / 2 + 1];
                Console.WriteLine($"{{ {result[0]}, {result[1]}, {result[2]} }}");
            }
        }
    }
}
