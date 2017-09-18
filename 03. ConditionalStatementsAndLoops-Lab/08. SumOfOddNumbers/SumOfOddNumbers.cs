using System;

namespace _08.SumOfOddNumbers
{
    public class SumOfOddNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(number);
                sum += number;
                number += 2;                
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
