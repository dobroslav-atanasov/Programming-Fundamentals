using System;

namespace _11.GeometryCalculator
{
    public class GeometryCalculator
    {
        static void Main()
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{CalculateAreaTriangle(side, height):F2}");
                    break;
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{CalculateAreaSquare(squareSide):F2}");
                    break;
                case "rectangle":
                    double rectangleSide = double.Parse(Console.ReadLine());
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{CalculateAreaRectangle(rectangleSide, rectangleHeight):F2}");
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{CalculateAreaCircle(radius):F2}");
                    break;
                default:
                    break;
            }
        }

        public static double CalculateAreaCircle(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double CalculateAreaSquare(double squareSide)
        {
            return squareSide * squareSide;
        }

        public static double CalculateAreaRectangle(double rectangleSide, double rectangleHeight)
        {
            return rectangleSide * rectangleHeight;
        }

        public static double CalculateAreaTriangle(double side, double height)
        {
            return (side * height) / 2.0;
        }
    }
}
