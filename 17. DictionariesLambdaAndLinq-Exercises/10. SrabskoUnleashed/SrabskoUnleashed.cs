using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10.SrabskoUnleashed
{
    public class SrabskoUnleashed
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, long>> concert = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            string pattern = @"(.*?)\s+@(.*?)\s+(\d+)\s+(\d+)";

            while (input != "End")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    string venue = match.Groups[2].Value;
                    string singer = match.Groups[1].Value;
                    int ticketPrice = int.Parse(match.Groups[3].Value);
                    int ticketCount = int.Parse(match.Groups[4].Value);

                    if (!concert.ContainsKey(venue))
                    {
                        concert.Add(venue, new Dictionary<string, long>());
                    }
                    if (!concert[venue].ContainsKey(singer))
                    {
                        concert[venue][singer] = 0;
                    }

                    concert[venue][singer] += ticketPrice * ticketCount;
                }

                input = Console.ReadLine();
            }

            foreach (var con in concert)
            {
                Console.WriteLine($"{con.Key}");
                foreach (var singer in con.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
