using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.AMinerTask
{
    public class AMinerTask
    {
        static void Main()
        {
            Dictionary<string, long> mine = new Dictionary<string, long>();

            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                long quantity = long.Parse(Console.ReadLine());

                if (!mine.ContainsKey(resource))
                {
                    mine[resource] = 0;
                }

                mine[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (var pair in mine)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
