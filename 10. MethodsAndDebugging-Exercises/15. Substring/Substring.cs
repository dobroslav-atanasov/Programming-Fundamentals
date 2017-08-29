using System;

namespace _15.Substring
{
    public class Substring
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;
                    int length = jump + 1;
                    string matchedString;
                    if (i + length <= text.Length)
                    {
                        matchedString = text.Substring(i, length);
                    }
                    else
                    {
                        matchedString = text.Substring(i);
                    }
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }
            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
