using System;

namespace _11.StringConcatenation
{
    public class StringConcatenation
    {
        static void Main()
        {
            char delimiter = char.Parse(Console.ReadLine());
            string oddOrEven = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string text = "";

            int start = 0;

            if (oddOrEven.Equals("odd"))
            {
                for (int i = 1; i <= n; i++)
                {
                    string word = Console.ReadLine();
                    if (i % 2 != 0)
                    {
                        text += word + delimiter;
                    }
                }
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    string word = Console.ReadLine();
                    if (i % 2 == 0)
                    {
                        text += word + delimiter;
                    }
                }
            }

            text = text.Substring(0, text.Length - 1);
            Console.WriteLine(text);
        }
    }
}
