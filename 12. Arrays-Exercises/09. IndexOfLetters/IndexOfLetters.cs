using System;
using System.Linq;

namespace _09.IndexOfLetters
{
    public class IndexOfLetters
    {
        static void Main()
        {
            char[] alphabet = new char[26];

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)(97 + i);
            }

            char[] text = Console.ReadLine().ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine($"{text[i]} -> {Array.IndexOf(alphabet, text[i])}");
            }
        }
    }
}
