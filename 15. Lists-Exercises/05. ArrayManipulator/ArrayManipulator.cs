using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ArrayManipulator
{
    public class ArrayManipulator
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "print")
            {
                string[] inputParts = input.Split(' ').ToArray();
                string command = inputParts[0];

                if (command.Equals("add"))
                {
                    int index = int.Parse(inputParts[1]);
                    int element = int.Parse(inputParts[2]);

                    list.Insert(index, element);
                }
                else if (command.Equals("addMany"))
                {
                    int index = int.Parse(inputParts[1]);
                    List<int> elements = new List<int>();

                    for (int i = 2; i < inputParts.Length; i++)
                    {
                        elements.Add(int.Parse(inputParts[i]));
                    }

                    list.InsertRange(index, elements);
                }
                else if (command.Equals("contains"))
                {
                    int element = int.Parse(inputParts[1]);

                    if (list.Contains(element))
                    {
                        Console.WriteLine(list.IndexOf(element));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (command.Equals("remove"))
                {
                    int index = int.Parse(inputParts[1]);

                    list.RemoveAt(index);
                }
                else if (command.Equals("shift"))
                {
                    int positions = int.Parse(inputParts[1]);

                    for (int i = 0; i < positions; i++)
                    {
                        int temp = list[0];
                        list.RemoveAt(0);
                        list.Add(temp);
                    }
                }
                else if (command.Equals("sumPairs"))
                {
                    List<int> sum = new List<int>();

                    if (list.Count % 2 == 0)
                    {
                        for (int i = 0; i < list.Count; i += 2)
                        {
                            sum.Add(list[i] + list[i + 1]);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < list.Count - 1; i += 2)
                        {
                            sum.Add(list[i] + list[i + 1]);
                        }

                        sum.Add(list[list.Count - 1]);
                    }

                    list = sum;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", list)}]");
        }
    }
}
