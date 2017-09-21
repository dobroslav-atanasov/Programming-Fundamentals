using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.MatchHexadecimalNumbers
{
    public class MatchHexadecimalNumbers
    {
        public static void Main()
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            string numbers = Console.ReadLine();

            List<string> hexadecimal = new List<string>();
            MatchCollection matches = Regex.Matches(numbers, pattern);
            foreach (Match number in matches)
            {
                hexadecimal.Add(number.ToString());
            }
            Console.WriteLine(string.Join(" ", hexadecimal));
        }
    }
}
