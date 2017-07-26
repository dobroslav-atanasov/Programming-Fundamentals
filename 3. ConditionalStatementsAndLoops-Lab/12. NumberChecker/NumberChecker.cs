using System;

namespace _12.NumberChecker
{
    public class NumberChecker
    {
        static void Main()
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
