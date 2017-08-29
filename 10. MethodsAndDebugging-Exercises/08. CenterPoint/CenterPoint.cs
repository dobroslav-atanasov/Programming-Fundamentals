using System;

namespace _08.CenterPoint
{
    public class CenterPoint
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestPoint(x1, y1, x2, y2);
        }

        public static void PrintClosestPoint(double x1, double y1, double x2, double y2)
        {
            double firstDist = Math.Sqrt(x1 * x1 + y1 * y1);
            double secondDist = Math.Sqrt(x2 * x2 + y2 * y2);

            if (firstDist <= secondDist)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
