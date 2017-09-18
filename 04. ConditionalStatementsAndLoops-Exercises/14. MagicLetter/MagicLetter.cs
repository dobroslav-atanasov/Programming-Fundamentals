using System;

namespace _14.MagicLetter
{
    public class MagicLetter
    {
        static void Main()
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            string noPrintLetter = Console.ReadLine();

            string combination = "";

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        combination = $"{i}{j}{k}";

                        if (combination.Contains(noPrintLetter))
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write(combination + " ");
                        }
                    }
                }
            }
        }
    }
}
