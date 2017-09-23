using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.UseYourChainsBuddy
{
    public class UseYourChainsBuddy
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string paragraphPattern = @"<p>(.[^\/]+)<\/p>";
            string linePattern = @"[^a-z0-9]+";

            MatchCollection matches = Regex.Matches(text, paragraphPattern);
            string word = "";
            foreach (Match match in matches)
            {
                string line = match.Groups[1].Value;
                word += Regex.Replace(line, linePattern, x => " ");
            }

            string finalWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                if ((int)word[i] >= 97 && (int)word[i] <= 109)
                {
                    finalWord += (char)((int)word[i] + 13);
                }
                else if ((int)word[i] >= 110 && (int)word[i] <= 122)
                {
                    finalWord += (char)((int)word[i] - 13);
                }
                else if (char.IsDigit(word[i]) || char.IsWhiteSpace(word[i]))
                {
                    finalWord += word[i];
                }
            }

            Console.WriteLine(finalWord);
        }
    }
}
