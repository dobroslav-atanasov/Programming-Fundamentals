using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Phonebook
{
    public class Phonebook
    {
        static void Main()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

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

                input = Console.ReadLine();
            }
        }
    }
}
