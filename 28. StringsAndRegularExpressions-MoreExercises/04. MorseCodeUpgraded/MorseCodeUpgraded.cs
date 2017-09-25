using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.MorseCodeUpgraded
{
    public class MorseCodeUpgraded
    {
        public static void Main()
        {
            string[] inputParts = Console.ReadLine().Split('|').ToArray();
            string zeroPattern = @"[0]{2,}";
            string onePattern = @"[1]{2,}";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < inputParts.Length; i++)
            {
                string letter = inputParts[i];
                int sumOne = 0;
                int sumZero = 0;
                for (int j = 0; j < letter.Length; j++)
                {
                    if (letter[j] == '0')
                    {
                        sumZero++;
                    }
                    else if (letter[j] == '1')
                    {
                        sumOne++;
                    }
                }
                int totalSum = sumOne * 5 + sumZero * 3;

                MatchCollection zeroMatches = Regex.Matches(letter, zeroPattern);
                foreach (Match match in zeroMatches)
                {
                    totalSum += match.Value.Length;
                }
                MatchCollection oneMatches = Regex.Matches(letter, onePattern);
                foreach (Match match in oneMatches)
                {
                    totalSum += match.Value.Length;
                }

                sb.Append((char)totalSum);
            }

            Console.WriteLine(sb);
        }
    }
}
