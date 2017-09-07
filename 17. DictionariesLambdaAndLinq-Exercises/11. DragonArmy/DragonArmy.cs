using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.DragonArmy
{
    public class DragonArmy
    {
        static void Main()
        {
            Dictionary<string, SortedDictionary<string, int[]>> army = new Dictionary<string, SortedDictionary<string, int[]>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string type = input[0];
                string name = input[1];
                int damage = 45;
                if (input[2] != "null")
                {
                    damage = int.Parse(input[2]);
                }
                int health = 250;
                if (input[3] != "null")
                {
                    health = int.Parse(input[3]);
                }
                int armor = 10;
                if (input[4] != "null")
                {
                    armor = int.Parse(input[4]);
                }

                if (!army.ContainsKey(type))
                {
                    army.Add(type, new SortedDictionary<string, int[]>());
                }
                if (!army[type].ContainsKey(name))
                {
                    army[type][name] = new int[3];
                }                
                army[type][name][0] = damage;
                army[type][name][1] = health;
                army[type][name][2] = armor;
            }

            foreach (var type in army)
            {
                Console.WriteLine($"{type.Key}::({(type.Value.Select(x => x.Value[0]).Average()):F2}/{(type.Value.Select(x => x.Value[1]).Average()):F2}/{(type.Value.Select(x => x.Value[2]).Average()):F2})");
                foreach (var name in type.Value)
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value[0]}, health: {name.Value[1]}, armor: {name.Value[2]}");
                }
            }
        }
    }
}
