using System;

namespace _10.CubeProperties
{
    public class CubeProperties
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            double result = 0;

            switch (type)
            {
                case "face":
                    result = CalculateFace(side);
                    break;
                case "space":
                    result = CalculateSpace(side);
                    break;
                case "volume":
                    result = CalculateVolume(side);
                    break;
                case "area":
                    result = CalculateArea(side);
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{result:F2}");
        }

        public static double CalculateArea(double side)
        {
            return 6 * Math.Pow(side, 2);
        }

        public static double CalculateVolume(double side)
        {
            return Math.Pow(side, 3);
        }

        public static double CalculateSpace(double side)
        {
            return Math.Sqrt(3 * (side * side));
        }

        private static double CalculateFace(double side)
        {
            return Math.Sqrt(2 * (side * side));
        }
    }
}
