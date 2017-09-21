using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.MatchNumbers
{
    public class MatchNumbers
    {
        public static void Main()
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            string numbers = Console.ReadLine();

            MatchCollection matches = Regex.Matches(numbers, pattern);
            List<string> nums = new List<string>();
            foreach (Match num in matches)
            {
                nums.Add(num.ToString());
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
