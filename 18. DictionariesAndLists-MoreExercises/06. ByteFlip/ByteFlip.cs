using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ByteFlip
{
    public class ByteFlip
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            input = input.Where(x => x.Length == 2).ToList();
            List<string> list = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                string str = input[i];
                string newStr = "";
                for (int j = str.Length - 1; j >= 0; j--)
                {
                    newStr += str[j];  
                }
                list.Add(newStr);
            }

            list.Reverse();
            string word = "";
            for (int i = 0; i < list.Count; i++)
            {
                char symbol = (char)(Convert.ToInt32(list[i], 16));
                word += symbol;
            }

            Console.WriteLine(word);
        }
    }
}
