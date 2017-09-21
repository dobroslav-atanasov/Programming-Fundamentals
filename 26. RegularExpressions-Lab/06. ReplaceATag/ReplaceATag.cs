using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _06.ReplaceATag
{
    public class ReplaceATag
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replacement = @"[URL href=$1]$2[/URL]";
                string replace = Regex.Replace(input, pattern, replacement);
                Console.WriteLine(replace);
                input = Console.ReadLine();
            }            
        }
    }
}
