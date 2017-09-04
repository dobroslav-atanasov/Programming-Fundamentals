using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AppendLists
{
    public class AppendLists
    {
        static void Main()
        {
            List<string> list = Console.ReadLine().Split('|').ToList();
            List<string> result = new List<string>();

            list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                var parts = list[i].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int j = 0; j < parts.Count; j++)
                {
                    result.Add(parts[j]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
