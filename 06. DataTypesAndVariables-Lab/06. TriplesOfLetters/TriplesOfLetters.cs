using System;

namespace _06.TriplesOfLetters
{
    public class TriplesOfLetters
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (char i = 'a'; i <= 'a' + n - 1; i++)
            {
                for (char j = 'a'; j <= 'a' + n - 1; j++)
                {
                    for (char k = 'a'; k <= 'a' + n - 1; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
