using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BombNumbers
{
    public class BombNumbers
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] inputParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int specialNumber = inputParts[0];
            int power = inputParts[1];

            int index = list.IndexOf(specialNumber);

            while (index != -1)
            {
                int left = Math.Max(index - power, 0);
                int right = Math.Min(index + power, list.Count - 1);

                list.RemoveRange(index, right - index);
                list.RemoveAt(index);
                list.RemoveRange(left, index - left);

                index = list.IndexOf(specialNumber);
            }

            Console.WriteLine(list.Sum());
        }
    }
}
