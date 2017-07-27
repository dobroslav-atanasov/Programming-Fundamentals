using System;

namespace _09.RefactorSpecialNumbers
{
    public class RefactorSpecialNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sumDigit = 0;
            int num = 0;
            bool isValid = false;

            for (int i = 1; i <= n; i++)
            {
                num = i;
                while (i > 0)
                {
                    sumDigit += i % 10;
                    i = i / 10;
                }
                isValid = (sumDigit == 5) || (sumDigit == 7) || (sumDigit == 11);
                Console.WriteLine($"{num} -> {isValid}");
                sumDigit = 0;
                i = num;
            }
        }
    }
}
