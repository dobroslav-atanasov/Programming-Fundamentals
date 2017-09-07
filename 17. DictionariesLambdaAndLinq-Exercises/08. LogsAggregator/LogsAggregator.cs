using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LogsAggregator
{
    public class LogsAggregator
    {
        static void Main()
        {
            SortedDictionary<string, long> nameDuration = new SortedDictionary<string, long>();
            Dictionary<string, List<string>> nameIp = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputParts = Console.ReadLine().Split(' ').ToArray();
                string ip = inputParts[0];
                string user = inputParts[1];
                long duration = long.Parse(inputParts[2]);

                if (!nameDuration.ContainsKey(user))
                {
                    nameDuration[user] = 0;
                }

                nameDuration[user] += duration;

                if (!nameIp.ContainsKey(user))
                {
                    nameIp[user] = new List<string>();
                }

                if (!nameIp[user].Contains(ip))
                {
                    nameIp[user].Add(ip);
                }
            }

            foreach (var name in nameDuration)
            {
                List<string> text = new List<string>();
                foreach (var ip in nameIp)
                {
                    if (ip.Key == name.Key)
                    {
                        foreach (var pair in ip.Value.OrderBy(x => x))
                        {
                            text.Add(pair);
                        }
                    }
                }
                Console.WriteLine($"{name.Key}: {name.Value} [{string.Join(", ", text)}]");
            }
        }
    }
}
