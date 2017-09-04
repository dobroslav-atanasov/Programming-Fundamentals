using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SplitByWordCasing
{
    public class SplitByWordCasing
    {
        static void Main()
        {
            var text = Console.ReadLine().Split(new[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ',}, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            bool isLower = false;
            bool isUpper = false;
            bool isMixed = false;

            for (int i = 0; i < text.Count; i++)
            {
                isLower = CheckIsLowerCase(text[i]);
                isUpper = CheckIsUpperCase(text[i]);
                if (isLower == false && isUpper == false)
                {
                    isMixed = true;
                }

                if (isLower)
                {
                    lowerCase.Add(text[i]);
                }
                else if (isUpper)
                {
                    upperCase.Add(text[i]);
                }
                else if (isMixed)
                {
                    mixedCase.Add(text[i]);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }

        public static bool CheckIsUpperCase(string word)
        {
            bool isValid = false;

            for (int i = 0; i < word.Length; i++)
            {
                if ((int)word[i] >= 65 && (int)word[i] <= 90)
                {
                    isValid = true;
                }
                else
                {
                    return false;
                }
            }

            return isValid;
        }

        public static bool CheckIsLowerCase(string word)
        {
            bool isValid = false;

            for (int i = 0; i < word.Length; i++)
            {
                if ((int)word[i] >= 97 && (int)word[i] <= 122)
                {
                    isValid = true;
                }
                else
                {
                    return false;
                }
            }

            return isValid;
        }
    }
}
