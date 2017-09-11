using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.CirclesIntersection
{
    public class CirclesIntersection
    {
        public static void Main()
        {
            int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Circle firstCircle = new Circle
            {
                X = first[0],
                Y = first[1],
                Radius = first[2]
            };

            Circle secondCircle = new Circle
            {
                X = second[0],
                Y = second[1],
                Radius = second[2]
            };

            bool isIntersect = CheckIsIntersect(firstCircle, secondCircle);
            Console.WriteLine(isIntersect ? "Yes" : "No");
        }

        public static bool CheckIsIntersect(Circle firstCircle, Circle secondCircle)
        {
            double distance = Math.Sqrt(Math.Pow(Math.Abs(firstCircle.X - secondCircle.X), 2) + Math.Pow(Math.Abs(firstCircle.Y - secondCircle.Y), 2));
            if (distance <= (firstCircle.Radius + secondCircle.Radius))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }
    }
}
