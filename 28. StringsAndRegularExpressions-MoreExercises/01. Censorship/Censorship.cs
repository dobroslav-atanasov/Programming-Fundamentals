using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.Censorship
{
    public class Censorship
    {
        public static void Main()
        {
            string bannedWord = Console.ReadLine();
            string text = Console.ReadLine();
            int index = text.IndexOf(bannedWord);
            string newWord = new string('*', bannedWord.Length);
            text = text.Replace(bannedWord, newWord);
            Console.WriteLine(text);
        }
    }
}
