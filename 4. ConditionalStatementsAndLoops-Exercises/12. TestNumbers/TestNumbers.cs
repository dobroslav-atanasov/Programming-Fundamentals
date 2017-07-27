using System;

namespace _12.TestNumbers
{
    public class TestNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int count = 0;
            int totalSum = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    totalSum += 3 * (i * j);
                    count++;

                    if (totalSum >= maxSum)
                    {
                        break;
                    }
                }

                if (totalSum >= maxSum)
                {
                    break;
                }
            }

            if (totalSum >= maxSum)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {totalSum}");
            }
        }
    }
}
