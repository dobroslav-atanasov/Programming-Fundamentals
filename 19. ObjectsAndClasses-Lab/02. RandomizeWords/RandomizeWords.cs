using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.RandomizeWords
{
    public class RandomizeWords
    {
        public static void Main()
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();
            Random random = new Random();

            for (int i = 0; i < text.Length; i++)
            {
                string currentWord = text[i];
                int index = random.Next(0, text.Length);

                string temp = text[index];
                text[i] = temp;
                text[index] = currentWord;
            }

            foreach (var word in text)
            {
                Console.WriteLine(word);
            }
        }
    }
}
