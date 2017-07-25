using System;

namespace _05.CharacterStats
{
    public class CharacterStats
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new string('|', health) + new string('.', maxHealth - health)}|");
            Console.WriteLine($"Energy: |{new string('|', energy) + new string('.', maxEnergy - energy)}|");
        }
    }
}
