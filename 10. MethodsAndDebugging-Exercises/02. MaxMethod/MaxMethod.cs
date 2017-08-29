using System;

namespace _02.MaxMethod
{
    public class MaxMethod
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            PrintMaxNumber(num1, num2, num3);
        }

        public static void PrintMaxNumber(int num1, int num2, int num3)
        {
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine(num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num3);
            }
        }
    }
}
