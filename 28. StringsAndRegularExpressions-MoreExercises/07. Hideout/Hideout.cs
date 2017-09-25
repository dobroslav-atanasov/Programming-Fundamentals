using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07.Hideout
{
    public class Hideout
    {
        public static void Main()
        {
            string map = Console.ReadLine();
            string[] inpuParts = Console.ReadLine().Split(' ').ToArray();

            while (true)
            {
                string symbol = inpuParts[0];
                string minCount = inpuParts[1];
                string pattern = $@"\{symbol}{{{minCount},}}";
                Match match = Regex.Match(map, pattern);
                if (match.Success)
                {
                    Console.WriteLine($"Hideout found at index {match.Index} and it is with size {match.Length}!");
                    break;
                }
                else
                {
                    inpuParts = Console.ReadLine().Split(' ').ToArray();
                }
            }
        }
    }
}
