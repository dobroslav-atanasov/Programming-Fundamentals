using System;

namespace _04.NumbersInReversedOrder
{
    public class NumbersInReversedOrder
    {
        static void Main()
        {
            string number = Console.ReadLine();
            PrintReverseNumber(number);
        }

        public static void PrintReverseNumber(string number)
        {
            string result = "";

            for (int i = number.Length - 1; i >= 0; i--)
            {
                result += number[i];
            }

            Console.WriteLine(result);
        }
    }
}
