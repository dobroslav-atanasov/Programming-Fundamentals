using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SafeManipulation
{
    public class SafeManipulation
    {
        static void Main()
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();

            string[] input = Console.ReadLine().Split(' ').ToArray();

            while (input[0] != "END")
            {
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
                    if (index >= 0 && index < list.Count)
                    {
                        string word = input[2];
                        list[index] = word;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
