using System;

namespace _03.MilesToKilometers
{
    public class MilesToKilometers
    {
        static void Main()
        {
            double mile = 1.60934;
            double kilometre = double.Parse(Console.ReadLine());
            double convert = mile * kilometre;

            Console.WriteLine($"{convert:F2}");
        }
    }
}
