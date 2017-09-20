using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.UnicodeCharacters
{
    public class UnicodeCharacters
    {
        public static void Main()
        {
            char[] text = Console.ReadLine().ToCharArray();
            StringBuilder sb = new StringBuilder();

            foreach (var @char in text)
            {
                sb.Append($"\\u{(int)(@char):x4}");
            }

            Console.WriteLine(sb);
        }
    }
}
