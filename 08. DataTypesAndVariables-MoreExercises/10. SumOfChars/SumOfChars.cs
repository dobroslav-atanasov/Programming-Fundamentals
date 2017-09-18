using System;

namespace _10.SumOfChars
{
    public class SumOfChars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sum += (int)symbol;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
