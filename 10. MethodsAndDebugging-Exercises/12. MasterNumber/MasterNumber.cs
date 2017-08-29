using System;

namespace _12.MasterNumber
{
    public class MasterNumber
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                bool isSymmetric = IsPalindrome(i);
                bool isSum = IsSumOfDigitDivide(i);
                bool isContainsEvenDigit = ContainsEvenDigit(i);

                if (isSymmetric && isSum && isContainsEvenDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool ContainsEvenDigit(int num)
        {
            int number = num;

            while (number != 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    return true;
                }
                number /= 10;
            }

            return false;
        }

        public static bool IsSumOfDigitDivide(int num)
        {
            int sum = 0;
            int number = num;

            while (number > 0)
            {
                int lastDigit = number % 10;
                sum += lastDigit;
                number /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPalindrome(int num)
        {
            string text = "" + num;

            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
