using System;

namespace _13.DecryptingMessage
{
    public class DecryptingMessage
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string text = "";

            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                text += (char)(symbol + key);
            }

            Console.WriteLine(text);
        }
    }
}
