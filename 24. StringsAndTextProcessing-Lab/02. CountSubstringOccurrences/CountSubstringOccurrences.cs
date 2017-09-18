using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.CountSubstringOccurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string searchStr = Console.ReadLine().ToLower();

            int index = text.IndexOf(searchStr);
            int count = 0;
            while (index != -1)
            {
                count++;
                index = text.IndexOf(searchStr, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
