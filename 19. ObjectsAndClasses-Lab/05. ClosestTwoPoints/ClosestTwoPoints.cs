using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ClosestTwoPoints
{
    public class ClosestTwoPoints
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                int[] pointParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Point point = new Point
                {
                    X = pointParts[0],
                    Y = pointParts[1]
                };

                points[i] = point;
            }

            Point[] closestPoints = FindClosestPoints(points);
            Console.WriteLine($"{(Math.Sqrt(Math.Pow(Math.Abs(closestPoints[0].X - closestPoints[1].X), 2) + Math.Pow(Math.Abs(closestPoints[0].Y - closestPoints[1].Y), 2))):F3}");
            Console.WriteLine($"({closestPoints[0].X}, {closestPoints[0].Y})");
            Console.WriteLine($"({closestPoints[1].X}, {closestPoints[1].Y})");
        }

        public static Point[] FindClosestPoints(Point[] points)
        {
            Point[] closestPoints = new Point[2];
            double leastDistance = double.MaxValue;
            double distance = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    Point first = points[i];
                    Point second = points[j];

                    distance = Math.Sqrt(Math.Pow(Math.Abs(first.X - second.X), 2) + Math.Pow(Math.Abs(first.Y - second.Y), 2));
                    if (distance < leastDistance)
                    {
                        leastDistance = distance;
                        closestPoints[0] = first;
                        closestPoints[1] = second;
                    }
                }
            }

            return closestPoints;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
