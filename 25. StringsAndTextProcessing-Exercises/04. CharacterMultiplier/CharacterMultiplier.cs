using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.CharacterMultiplier
{
    public class CharacterMultiplier
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');
            char[] first = words[0].ToCharArray();
            char[] second = words[1].ToCharArray();
            long sum = 0;
            
            if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    int multiply = CalculateChar(first[i], second[i]);
                    sum += multiply;
                }                
            }
            else
            {
                char[] shorter = null;
                char[] longer = null;
                if (first.Length < second.Length)
                {
                    shorter = first;
                    longer = second;
                }
                else if (first.Length > second.Length)
                {
                    shorter = second;
                    longer = first;
                }
                for (int i = 0; i < shorter.Length; i++)
                {
                    int multiply = CalculateChar(shorter[i], longer[i]);
                    sum += multiply;
                }
                for (int i = shorter.Length; i < longer.Length; i++)
                {
                    sum += (int)longer[i];
                }
            }

            Console.WriteLine(sum);
        }

        public static int CalculateChar(char v1, char v2)
        {
            return (int)v1 * (int)v2;
        }
    }
}
