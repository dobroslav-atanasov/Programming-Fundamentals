using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    public class MatchPhoneNumber
    {
        public static void Main()
        {
            string pattern = @"\+359(\s|\-)2\1\d{3}\1\d{4}\b";
            string numbers = Console.ReadLine();
            List<string> result = new List<string>();

            MatchCollection matches = Regex.Matches(numbers, pattern);
            foreach (Match number in matches)
            {
                result.Add(number.ToString());
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
