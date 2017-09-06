using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    public class OddOccurrences
    {
        static void Main()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string[] words = Console.ReadLine().ToLower().Split(' ').ToArray();

            foreach (string word in words)
            {
                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = 0;
                }

                dictionary[word]++;
            }

            List<string> result = new List<string>();
            foreach (var word in dictionary)
            {
                if (word.Value % 2 != 0)
                {
                    result.Add(word.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
