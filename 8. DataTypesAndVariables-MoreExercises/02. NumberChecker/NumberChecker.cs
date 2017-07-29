using System;

namespace _02.NumberChecker
{
    public class NumberChecker
    {
        static void Main()
        {
            string str = Console.ReadLine();

            if (long.TryParse(str, out long number))
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
