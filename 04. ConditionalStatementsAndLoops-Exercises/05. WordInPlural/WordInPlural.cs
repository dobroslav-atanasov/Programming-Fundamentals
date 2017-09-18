using System;

namespace _05.WordInPlural
{
    public class WordInPlural
    {
        static void Main()
        {
            string noun = Console.ReadLine();

            char lastLetter = noun[noun.Length - 1];

            if (lastLetter == 'y')
            {
                string newString = noun.Substring(0, noun.Length - 1);
                string pluralize = newString + "ies";
                Console.WriteLine(pluralize);
            }
            else if (lastLetter == 'o' || lastLetter == 's' || lastLetter == 'x' || lastLetter == 'z')
            {
                string pluralize = noun + "es";
                Console.WriteLine(pluralize);
            }
            else if (lastLetter == 'h')
            {
                char secondLastLetter = noun[noun.Length - 2];

                if (secondLastLetter == 's')
                {
                    string pluralize = noun + "es";
                    Console.WriteLine(pluralize);
                }
                else if (secondLastLetter == 'c')
                {
                    string pluralize = noun + "es";
                    Console.WriteLine(pluralize);
                }
                else
                {
                    string pluralize = noun + "s";
                    Console.WriteLine(pluralize);
                }
            }
            else
            {
                string pluralize = noun + "s";
                Console.WriteLine(pluralize);
            }
        }
    }
}
