using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.LegendaryFarming
{
    public class LegendaryFarming
    {
        static void Main()
        {
            Dictionary<string, int> keyMaterial = new Dictionary<string, int>();
            keyMaterial["shards"] = 0;
            keyMaterial["fragments"] = 0;
            keyMaterial["motes"] = 0;
            Dictionary<string, int> junkMaterial = new Dictionary<string, int>();
            string input = Console.ReadLine();
            bool isValid = true;

            while (true)
            {
                List<string> list = input.ToLower().Split(' ').ToList();
                for (int i = 0; i < list.Count; i += 2)
                {
                    int qunatity = int.Parse(list[i]);
                    string material = list[i + 1];

                    if (material.Equals("shards") || material.Equals("fragments") || material.Equals("motes"))
                    {
                        keyMaterial[material] += qunatity;
                    }
                    else
                    {
                        if (!junkMaterial.ContainsKey(material))
                        {
                            junkMaterial[material] = 0;
                        }
                        junkMaterial[material] += qunatity;
                    }

                    if (keyMaterial.Any(x => x.Value >= 250))
                    {
                        isValid = false;
                        break;
                    }
                }

                if (!isValid)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            foreach (var material in keyMaterial.OrderByDescending(x => x.Value))
            {
                switch (material.Key)
                {
                    case "shards": Console.WriteLine("Shadowmourne obtained!"); keyMaterial[material.Key] -= 250; break;
                    case "fragments": Console.WriteLine("Valanyr obtained!"); keyMaterial[material.Key] -= 250; break;
                    case "motes": Console.WriteLine("Dragonwrath obtained!"); keyMaterial[material.Key] -= 250; break;
                    default: break;
                }
                break;
            }

            foreach (var material in keyMaterial.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var material in junkMaterial.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
