using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ManipulateArray
{
    public class ManipulateArray
    {
        static void Main()
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                if (input[0].Equals("Distinct"))
                {
                    list = list.Distinct().ToList();
                }
                else if (input[0].Equals("Reverse"))
                {
                    list.Reverse();
                }
                else if (input[0].Equals("Replace"))
                {
                    int index = int.Parse(input[1]);
                    string word = input[2];
                    list[index] = word;
                }
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
