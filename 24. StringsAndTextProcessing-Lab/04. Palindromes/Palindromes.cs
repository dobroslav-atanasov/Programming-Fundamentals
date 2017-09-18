using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            List<string> palindromes = new List<string>();
            string[] words = Console.ReadLine().Split(new[] { ',', '?', '!', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (var word in words)
            {
                bool isPalindrome = false;
                if (word.Length == 1)
                {
                    palindromes.Add(word);
                }
                else
                {
                    for (int i = 0; i < word.Length / 2; i++)
                    {
                        if (word[i] == word[word.Length - 1 - i])
                        {
                            isPalindrome = true;
                        }
                        else
                        {
                            isPalindrome = false;
                            break;
                        }
                    }
                    if (isPalindrome)
                    {
                        palindromes.Add(word);
                    }
                }
            }

            palindromes = palindromes.Distinct().ToList();
            palindromes.Sort();

            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}
