using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SearchForANumber
{
    public class SearchForANumber
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int takeElement = array[0];
            int deleteElement = array[1];
            int searchNumber = array[2];

            list = list.Take(takeElement).ToList();
            list.RemoveRange(0, deleteElement);

            if (list.Contains(searchNumber))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
