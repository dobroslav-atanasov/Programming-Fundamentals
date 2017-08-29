using System;
using System.Numerics;

namespace _14.FactorialTrailingZeroes
{
    public class FactorialTrailingZeroes
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            int count = CalculateNumber(factorial);

            Console.WriteLine(count);
        }

        public static int CalculateNumber(BigInteger factorial)
        {
            string numberAsText = factorial.ToString();
            int count = 0;

            for (int i = numberAsText.Length - 1; i >= 0; i--)
            {
                if (numberAsText[i] != '0')
                {
                    break;
                }
                else
                {
                    count++;
                }
            }

            return count;
        }
    }
}