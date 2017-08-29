using System;

namespace _05.FibonacciNumbers
{
    public class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int fibonacci = CalculateFibonacci(n);

            Console.WriteLine(fibonacci);
        }

        public static int CalculateFibonacci(int n)
        {
            int f0 = 0;
            int f1 = 1;
            for (int i = 0; i <= n; i++)
            {
                int temp = f0;
                f0 = f1;
                f1 = temp + f0;
            }

            return f0;
        }
    }
}
