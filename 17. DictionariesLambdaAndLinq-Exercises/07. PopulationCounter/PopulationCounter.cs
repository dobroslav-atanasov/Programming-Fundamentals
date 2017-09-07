using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PopulationCounter
{
    public class PopulationCounter
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, long>> stat = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] inputParts = input.Split('|').ToArray();
                string town = inputParts[0];
                string country = inputParts[1];
                long population = long.Parse(inputParts[2]);

                if (!stat.ContainsKey(country))
                {
                    stat[country] = new Dictionary<string, long>();
                    stat[country].Add(town, population);
                }
                else
                {
                    if (!stat[country].ContainsKey(town))
                    {
                        stat[country][town] = 0;
                    }

                    stat[country][town] += population;
                }

                input = Console.ReadLine();
            }

            foreach (var count in stat.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{count.Key} (total population: {count.Value.Values.Sum()})");

                foreach (var city in count.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
