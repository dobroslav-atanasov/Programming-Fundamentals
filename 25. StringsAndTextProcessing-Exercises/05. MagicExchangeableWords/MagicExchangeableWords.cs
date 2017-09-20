using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.MagicExchangeableWords
{
    public class MagicExchangeableWords
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');
            HashSet<char> firstWord = new HashSet<char>(words[0]);
            HashSet<char> secondWord = new HashSet<char>(words[1]);
            
            Console.WriteLine((firstWord.Count == secondWord.Count) ? "true" : "false");
        }
    }
}
