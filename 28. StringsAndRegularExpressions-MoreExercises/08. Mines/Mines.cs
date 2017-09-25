using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.Mines
{
    public class Mines
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int startIndex = input.IndexOf("<", 0);
            int endIndex = input.IndexOf(">", 0);
            StringBuilder mines = new StringBuilder(input);

            while (startIndex != -1 && endIndex != - 1)
            {
                string bomb = input.Substring(startIndex + 1, 2);
                int power = CalculatePower(bomb);
                int startReplece = Math.Max(0, startIndex - power);
                int endReplace = Math.Min(input.Length - 1, endIndex + power);

                for (int i = startReplece; i <= endReplace; i++)
                {
                    mines[i] = '_'; 
                }

                startIndex = input.IndexOf("<", startIndex + 1);
                endIndex = input.IndexOf(">", endIndex + 1);
            }

            Console.WriteLine(mines);
        }

        public static int CalculatePower(string bomb)
        {
            char first = bomb[0];
            char second = bomb[1];
            int power = Math.Abs(first - second);
            return power;
        }
    }
}
