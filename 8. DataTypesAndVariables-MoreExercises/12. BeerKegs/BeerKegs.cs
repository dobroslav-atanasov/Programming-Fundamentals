using System;

namespace _12.BeerKegs
{
    public class BeerKegs
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string biggerKeg = "";
            double biggerVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                long height = long.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;
                if (volume >= biggerVolume)
                {
                    biggerVolume = volume;
                    biggerKeg = model;
                }
            }

            Console.WriteLine(biggerKeg);
        }
    }
}
