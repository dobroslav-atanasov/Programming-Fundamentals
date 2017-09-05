using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    public class ChangeList
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var input = Console.ReadLine();

            while (input != "Odd" && input != "Even")
            {
                var inputParts = input.Split(' ').ToArray();
                string command = inputParts[0];

                if (command.Equals("Delete"))
                {
                    int element = int.Parse(inputParts[1]);
                    list.RemoveAll(x => x == element);
                }
                else if (command.Equals("Insert"))
                {
                    int element = int.Parse(inputParts[1]);
                    int index = int.Parse(inputParts[2]);
                    list.Insert(index, element);
                }

                input = Console.ReadLine();
            }

            if (input == "Odd")
            {
                list = list.Where(x => x % 2 != 0).ToList();
                Console.WriteLine(string.Join(" ", list));
            }
            else if (input == "Even")
            {
                list = list.Where(x => x % 2 == 0).ToList();
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}
