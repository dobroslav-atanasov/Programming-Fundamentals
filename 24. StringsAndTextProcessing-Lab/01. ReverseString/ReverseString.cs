using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.ReverseString
{
    public class ReverseString
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            string newStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                newStr += str[i];
            }
            Console.WriteLine(newStr);
        }
    }
}
