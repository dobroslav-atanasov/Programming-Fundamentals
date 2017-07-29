using System;

namespace _09.MakeAWord
{
    public class MakeAWord
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string word = "";

            for (int i = 0; i < n; i++)
            {
                string symbol = Console.ReadLine();
                word += symbol;
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}
