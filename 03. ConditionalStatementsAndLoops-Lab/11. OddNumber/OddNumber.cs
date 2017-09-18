using System;

namespace _11.OddNumber
{
    public class OddNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            while (true)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }

                number = int.Parse(Console.ReadLine());
            }
        }
    }
}
