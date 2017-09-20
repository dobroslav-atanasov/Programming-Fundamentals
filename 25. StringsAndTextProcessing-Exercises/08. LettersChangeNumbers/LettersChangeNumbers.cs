using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _08.LettersChangeNumbers
{
    public class LettersChangeNumbers
    {
        public static void Main()
        {
            string[] elements = Console.ReadLine().Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            foreach (var element in elements)
            {
                char firstLetter = element.First();
                char lastLetter = element.Last();
                double number = double.Parse(element.Substring(1, element.Length - 2));

                if (char.IsUpper(firstLetter))
                {
                    number /= firstLetter - ('A' - 1);
                }
                else
                {
                    number *= firstLetter - ('a' - 1);
                }

                if (char.IsUpper(lastLetter))
                {
                    number -= lastLetter - ('A' - 1);
                }
                else
                {
                    number += lastLetter - ('a' - 1);
                }

                sum += number;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
