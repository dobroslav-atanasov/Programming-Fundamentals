using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.DistanceBetweenPoints
{
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point firstPoint = new Point
            {
                X = first[0],
                Y= first[1]
            };

            Point secondPoint = new Point
            {
                X = second[0],
                Y = second[1]
            };

            double distance = CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine($"{distance:F3}");
        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            double distance = Math.Sqrt(Math.Pow(Math.Abs(firstPoint.X - secondPoint.X), 2) + Math.Pow(Math.Abs(firstPoint.Y - secondPoint.Y), 2));
            return distance;
        }
    }

    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }
    }
}
