using System;

namespace _03.Megapixels
{
    public class Megapixels
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double megapixels = Math.Round(width * height / 1_000_000.0, 1);

            Console.WriteLine($"{width}x{height} => {megapixels}MP");
        }
    }
}
