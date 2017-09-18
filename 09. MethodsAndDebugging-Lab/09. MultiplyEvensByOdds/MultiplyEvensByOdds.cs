using System;

namespace _09.MultiplyEvensByOdds
{
    public class MultiplyEvensByOdds
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int result = MultiplyEvenAndOdd(Math.Abs(num));

            Console.WriteLine(result);
        }

        public static int MultiplyEvenAndOdd(int num)
        {
            int oddDigit = GetSumOddDigit(num);
            int evenDigit = GetSumEvenDigit(num);
            return oddDigit * evenDigit;
        }

        public static int GetSumEvenDigit(int num)
        {
            int number = num;
            int sum = 0;

            while (number != 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }

            return sum;
        }

        public static int GetSumOddDigit(int num)
        {
            int number = num;
            int sum = 0;

            while (number != 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }

            return sum;
        }
    }
}
