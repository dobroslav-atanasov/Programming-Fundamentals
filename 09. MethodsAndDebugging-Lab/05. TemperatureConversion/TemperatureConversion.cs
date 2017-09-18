using System;

namespace _05.TemperatureConversion
{
    public class TemperatureConversion
    {
        static void Main()
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = CalculateCelsius(fahrenheit);
            Console.WriteLine($"{celsius:F2}");
        }

        public static double CalculateCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9.0;
            return celsius;
        }
    }
}
