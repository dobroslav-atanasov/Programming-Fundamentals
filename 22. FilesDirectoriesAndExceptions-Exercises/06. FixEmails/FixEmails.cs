using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _06.FixEmails
{
    public class FixEmails
    {
        public static void Main()
        {
            var input = File.ReadAllLines(@"..\..\Input.txt");

            var dict = new Dictionary<string, string>();

            var name = "";
            var email = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    name = input[i];
                }
                else
                {
                    email = input[i];
                    var domain = email.Substring(email.Length - 2);
                    if (domain == "uk" || domain == "us")
                    {
                        continue;
                    }
                    else
                    {
                        dict.Add(name, email);
                    }
                }
                if (name == "stop")
                {
                    break;
                }
            }

            var result = "";
            foreach (var item in dict)
            {
                result = $"{item.Key} -> {item.Value}";
                File.AppendAllText(@"..\..\Output.txt", result + Environment.NewLine);
            }
        }
    }
}
