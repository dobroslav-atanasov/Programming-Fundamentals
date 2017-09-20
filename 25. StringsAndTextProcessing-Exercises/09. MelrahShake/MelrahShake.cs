using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.MelrahShake
{
    public class MelrahShake
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            string pattern = Console.ReadLine();
            
            while (true)
            {
                int firstIndex = str.IndexOf(pattern);
                int lastIndex = str.LastIndexOf(pattern);

                if (firstIndex >= 0 && lastIndex >= 0 && pattern.Length > 0)
                {
                    str = str.Remove(lastIndex, pattern.Length);
                    str = str.Remove(firstIndex, pattern.Length);
                    int symbolIndex = pattern.Length / 2;
                    pattern = pattern.Remove(symbolIndex, 1);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }
            }
            Console.WriteLine(str);
        }
    }
}
