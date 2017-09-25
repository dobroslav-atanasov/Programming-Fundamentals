using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.OnlyLetters
{
    public class OnlyLetters
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"(\d+)([A-z]{1})";
            string replacement = "";
            StringBuilder newText = new StringBuilder(); 

            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                string str = match.Value;
                char symbol = str[str.Length - 1];
                text = text.Replace(str, new string(symbol, 2));
            }

            Console.WriteLine(text);
        }
    }
}
