using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _05.AMinerTask
{
    public class AMinerTask
    {
        public static void Main()
        {
            var input = File.ReadAllLines(@"..\..\Input.txt");

            var dict = new Dictionary<string, long>();

            var resource = "";
            var quantity = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    resource = input[i];
                }
                else
                {
                    quantity = int.Parse(input[i]);
                    if (!dict.ContainsKey(resource))
                    {
                        dict.Add(resource, quantity);
                    }
                    else
                    {
                        dict[resource] += quantity;
                    }
                }
                if (resource == "stop")
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
