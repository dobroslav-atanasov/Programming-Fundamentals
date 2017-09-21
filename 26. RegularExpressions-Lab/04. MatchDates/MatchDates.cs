using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.MatchDates
{
    public class MatchDates
    {
        public static void Main()
        {
            string pattern = @"\b(\d{2})(\.|\-|\/)([A-Z]{1}[a-z]{2})\2(\d{4})\b";
            string dates = Console.ReadLine();

            MatchCollection matches = Regex.Matches(dates, pattern);
            foreach (Match date in matches)
            {
                Console.WriteLine($"Day: {date.Groups[1]}, Month: {date.Groups[3]}, Year: {date.Groups[4]}");
            }
        }
    }
}
