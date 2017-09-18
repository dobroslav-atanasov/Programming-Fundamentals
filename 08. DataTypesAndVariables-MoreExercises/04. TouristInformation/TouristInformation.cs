using System;

namespace _04.TouristInformation
{
    public class TouristInformation
    {
        static void Main()
        {
            string unit = Console.ReadLine();
            double length = double.Parse(Console.ReadLine());

            switch (unit)
            {
                case "miles":
                    double kilometers = 1.6 * length;
                    Console.WriteLine($"{length} {unit} = {kilometers:F2} kilometers");
                    break;
                case "inches":
                    double centimeters = 2.54 * length;
                    Console.WriteLine($"{length} {unit} = {centimeters:F2} centimeters");
                    break;
                case "feet":
                    double centimeter = 30 * length;
                    Console.WriteLine($"{length} {unit} = {centimeter:F2} centimeters");
                    break;
                case "yards":
                    double meters = 0.91 * length;
                    Console.WriteLine($"{length} {unit} = {meters:F2} meters");
                    break;
                case "gallons":
                    double leters = 3.8 * length;
                    Console.WriteLine($"{length} {unit} = {leters:F2} liters");
                    break;
                default:
                    break;
            }
        }
    }
}
