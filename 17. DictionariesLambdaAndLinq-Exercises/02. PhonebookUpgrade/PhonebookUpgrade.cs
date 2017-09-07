using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.PhonebookUpgrade
{
    public class PhonebookUpgrade
    {
        static void Main()
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] inputParts = input.Split(' ').ToArray();
                string command = inputParts[0];

                if (command.Equals("A"))
                {
                    string name = inputParts[1];
                    string phone = inputParts[2];

                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook[name] = phone;
                    }
                    else
                    {
                        phonebook[name] = phone;
                    }
                }
                else if (command.Equals("S"))
                {
                    string name = inputParts[1];

                    if (!phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                }
                else if (command.Equals("ListAll"))
                {
                    foreach (var pair in phonebook)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
