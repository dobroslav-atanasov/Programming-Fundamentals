using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ImmuneSystem
{
    public class ImmuneSystem
    {
        static void Main()
        {
            List<string> viruses = new List<string>();
            int health = int.Parse(Console.ReadLine());
            int maxHealth = health;
            bool isValid = true;

            string input = Console.ReadLine();

            while (input != "end")
            {
                int virusStrength = CalculateVirusStrength(input);
                int timeToDefeat = virusStrength * input.Length;
                if (viruses.Contains(input))
                {
                    timeToDefeat = (int)(timeToDefeat / 3.0); 
                }
                else
                {
                    viruses.Add(input);
                }

                TimeSpan ts = TimeSpan.FromSeconds(timeToDefeat);
                health -= timeToDefeat;
                Console.WriteLine($"Virus {input}: {virusStrength} => {timeToDefeat} seconds");
                if (health <= 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    isValid = false;
                    break;
                }
                else
                {
                    Console.WriteLine($"{input} defeated in {ts.Minutes}m {ts.Seconds}s.");
                    Console.WriteLine($"Remaining health: {health}");
                }
                health = Math.Min(maxHealth, (int)(health + (health * 0.2)));
                input = Console.ReadLine();
            }

            if (isValid)
            {
                Console.WriteLine($"Final Health: {health}");
            }            
        }

        public static int CalculateVirusStrength(string input)
        {
            int virusStrength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                virusStrength += input[i];
            }

            return (int)(virusStrength / 3.0);
        }
    }
}
