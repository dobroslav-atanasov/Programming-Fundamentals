using System;

namespace _06.CalculateTriangleArea
{
    public class CalculateTriangleArea
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area = CalculateArea(a, b);
            Console.WriteLine($"{area}");
        }

        public static double CalculateArea(double a, double b)
        {
            double area = (a * b) / 2.0;
            return area;
        }
    }
}
