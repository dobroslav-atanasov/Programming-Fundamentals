using System;

namespace _04.BeverageLabels
{
    public class BeverageLabels
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            double calEnergy = energy * (volume / 100.0);
            double calSugar = sugar * (volume / 100.0);
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{calEnergy}kcal, {calSugar}g sugars");
        }
    }
}
