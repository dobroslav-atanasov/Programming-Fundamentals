using System;

namespace _07.MathPower
{
    public class MathPower
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculatePower(number, power));
        }

        public static double CalculatePower(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
