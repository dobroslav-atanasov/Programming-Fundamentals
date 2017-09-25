using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.KarateStrings
{
    public class KarateStrings
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int strength = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    strength += int.Parse(text[i + 1].ToString());
                    i++;
                    while (strength > 0 && i < text.Length)
                    {
                        if (text[i] == '>')
                        {
                            break;
                        }
                        text = text.Remove(i, 1);
                        strength--;
                    }
                    i--;
                }
            }

            Console.WriteLine(text);
        }
    }
}
