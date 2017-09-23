using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _06.ValidUsernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            string[] lines = Console.ReadLine().Split(new char[] { ' ', '\\', '/', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"\b[A-z][A-z0-9_]{2,24}\b";
            List<string> words = new List<string>();

            foreach (var line in lines)
            {
                Match match = Regex.Match(line, pattern);
                if (match.Success)
                {
                    words.Add(match.Value);
                }
            }

            int sum = 0;
            int maxSum = 0;
            string firstWord = "";
            string secondWord = "";
            for (int i = 0; i < words.Count - 1; i++)
            {
                sum = words[i].Length + words[i + 1].Length;
                if (sum > maxSum)
                {
                    maxSum = sum;
                    firstWord = words[i];
                    secondWord = words[i + 1]; 
                }
            }

            Console.WriteLine(firstWord);
            Console.WriteLine(secondWord);
        }
    }
}
