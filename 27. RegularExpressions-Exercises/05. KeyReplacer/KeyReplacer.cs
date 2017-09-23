using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.KeyReplacer
{
    public class KeyReplacer
    {
        public static void Main()
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();
            string word = "";

            string keyPattern = @"^([A-z]+)(\<|\||\\)(.*?)(\<|\||\\)([A-z]+)$";
            Match keyMatch = Regex.Match(key, keyPattern);

            if (keyMatch.Success)
            {
                string startKey = keyMatch.Groups[1].Value;
                string endKey = keyMatch.Groups[5].Value;
                string textPattern = $@"({startKey})(.*?)({endKey})";

                MatchCollection matches = Regex.Matches(text, textPattern);
                foreach (Match match in matches)
                {
                    word += match.Groups[2].Value;
                }

                if (word.Length == 0)
                {
                    Console.WriteLine("Empty result");
                }
                else
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
