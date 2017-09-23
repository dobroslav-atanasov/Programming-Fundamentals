using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.ExtractEmails
{
    public class ExtractEmails
    {
        public static void Main()
        {
            string pattern = @"(?<=\s)[a-z0-9]+([.-]\w*)*@[a-z]+([.-]\w*)*(\.[a-z]+)";
            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match email in matches)
            {
                Console.WriteLine(email);
            }
        }
    }
}
