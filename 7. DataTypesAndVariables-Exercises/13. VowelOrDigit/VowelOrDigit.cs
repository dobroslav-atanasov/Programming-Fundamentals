using System;

namespace _13.VowelOrDigit
{
    public class VowelOrDigit
    {
        static void Main()
        {
            string symbol = Console.ReadLine();

            if (int.TryParse(symbol, out int num))
            {
                Console.WriteLine("digit");
            }
            else
            {
                switch (symbol)
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        Console.WriteLine("vowel");
                        break;
                    default:
                        Console.WriteLine("other");
                        break;
                }
            }
        }
    }
}
