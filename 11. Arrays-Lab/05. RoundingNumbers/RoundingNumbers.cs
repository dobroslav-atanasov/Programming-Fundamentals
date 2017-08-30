using System;
using System.Linq;

namespace _05.RoundingNumbers
{
    public class RoundingNumbers
    {
        static void Main()
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} => {Math.Round(array[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
