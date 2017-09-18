using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.TextFilter
{
    public class TextFilter
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
