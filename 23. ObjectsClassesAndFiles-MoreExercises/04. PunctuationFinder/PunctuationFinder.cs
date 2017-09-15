using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04.PunctuationFinder
{
    public class PunctuationFinder
    {
        public static void Main()
        {
            string text = File.ReadAllText(@"..\..\Input.txt");
            List<char> symbols = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.' || text[i] == ',' || text[i] == '!' || text[i] == '?' || text[i] == ':')
                {
                    symbols.Add(text[i]);
                }
            }

            List<string> result = new List<string>();
            foreach (var symbol in symbols)
            {
                result.Add(symbol.ToString());
            }

            File.WriteAllText(@"..\..\Output.txt", string.Join(", ", result));
        }
    }
}
