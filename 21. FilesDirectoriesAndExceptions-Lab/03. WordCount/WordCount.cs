using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _03.WordCount
{
    public class WordCount
    {
        public static void Main()
        {
            Dictionary<string, int> counter = new Dictionary<string, int>();
            string line = File.ReadAllText(@"..\..\Words.txt");
            string[] words = line.Split(' ').ToArray();
            string[] text = File.ReadAllText(@"..\..\Input.txt").ToLower().Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in text)
            {
                if (words.Contains(word))
                {
                    if (!counter.ContainsKey(word))
                    {
                        counter[word] = 0;
                    }
                    counter[word]++;
                } 
            }

            foreach (var pair in counter.OrderByDescending(x => x.Value))
            {
                string newLine = $"{pair.Key} - {pair.Value}" + Environment.NewLine;
                File.AppendAllText(@"..\..\Output.txt", newLine);
            }
        }
    }
}
