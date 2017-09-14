using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _02.IndexOfLetters
{
    public class IndexOfLetters
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines(@"..\..\Input.txt");

            char[] array = input[0].ToArray();

            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)('a' + i);
            }

            for (int i = 0; i < array.Length; i++)
            {
                var result = $"{array[i]} -> {Array.IndexOf(alphabet, array[i])}";
                File.AppendAllText(@"..\..\Output.txt", result + Environment.NewLine);
            }
        }
    }
}
