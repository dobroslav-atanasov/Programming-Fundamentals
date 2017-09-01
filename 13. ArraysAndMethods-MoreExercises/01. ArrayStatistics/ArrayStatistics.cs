using System;
using System.Linq;

namespace _01.ArrayStatistics
{
    public class ArrayStatistics
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int min = CalculateMin(array);
            int max = CalculateMax(array);
            long sum = CalculateSum(array);
            double average = CalculateAverage(array);

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }

        public static double CalculateAverage(int[] array)
        {
            long sum = CalculateSum(array);
            double average = sum / (double)array.Length;
            return average;
        }

        public static long CalculateSum(int[] array)
        {
            long sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public static int CalculateMax(int[] array)
        {
            int max = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public static int CalculateMin(int[] array)
        {
            int min = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }
    }
}
