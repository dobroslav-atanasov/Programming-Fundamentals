using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.ExtractSentencesByKeyword
{
    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            string key = Console.ReadLine();
            string[] text = Console.ReadLine().Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var sentence in text)
            {
                string pattern = @"[^A-z]";
                string[] words = Regex.Split(sentence, pattern);
                if (words.Contains(key))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
