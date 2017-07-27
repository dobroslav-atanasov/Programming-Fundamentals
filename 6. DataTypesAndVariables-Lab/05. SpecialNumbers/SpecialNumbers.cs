using System;

namespace _05.SpecialNumbers
{
    public class SpecialNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sumDigit = 0;
                int lastDigit = 0;
                int num = i;

                while (num != 0)
                {
                    lastDigit = num % 10;
                    sumDigit += lastDigit;
                    num /= 10;
                }

                if (sumDigit == 5 || sumDigit == 7 || sumDigit == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
