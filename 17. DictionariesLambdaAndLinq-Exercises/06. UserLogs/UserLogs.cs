using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.UserLogs
{
    public class UserLogs
    {
        static void Main()
        {
            SortedDictionary<string, Dictionary<string, int>> dict = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputParts = input.Split(' ').ToArray();
                string ip = inputParts[0].Substring(3, inputParts[0].Length - 3);
                string message = inputParts[1].Substring(9, inputParts[1].Length - 10);
                string user = inputParts[2].Substring(5, inputParts[2].Length - 5);

                if (!dict.ContainsKey(user))
                {
                    dict[user] = new Dictionary<string, int>();
                    dict[user].Add(ip, 1);
                }
                else
                {
                    if (!dict[user].ContainsKey(ip))
                    {
                        dict[user][ip] = 0;
                    }

                    dict[user][ip]++;
                }

                input = Console.ReadLine();
            }

            foreach (var user in dict)
            {
                Console.WriteLine($"{user.Key}:");
                var ipCounts = user.Value.ToDictionary(k => k.Key, v => v.Value);
                List<string> list = new List<string>();

                foreach (var pair in ipCounts)
                {
                    list.Add($"{pair.Key} => {pair.Value}");
                }
                Console.WriteLine($"{string.Join(", ", list)}.");
            }
        }
    }
}
