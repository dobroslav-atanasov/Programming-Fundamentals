using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _06.EmailStatistics
{
    public class EmailStatistics
    {
        public static void Main()
        {
            Dictionary<string, List<string>> domains = new Dictionary<string, List<string>>();
            string pattern = @"^([A-Za-z]{5,})@(([a-z]{3,})([.com]+|[.bg]+|[.org]+))$";
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string inputEmail = Console.ReadLine();
                Match match = Regex.Match(inputEmail, pattern);
                if (match.Success)
                {
                    string username = match.Groups[1].Value;
                    string domain = match.Groups[2].Value;
                    if (!domains.ContainsKey(domain))
                    {
                        domains[domain] = new List<string>();
                    }
                    if (!domains[domain].Contains(username))
                    {
                        domains[domain].Add(username);
                    }                    
                }
            }

            foreach (var domain in domains.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{domain.Key}:");
                foreach (var user in domain.Value)
                {
                    Console.WriteLine($"### {user}");
                }
            }
        }
    }
}
