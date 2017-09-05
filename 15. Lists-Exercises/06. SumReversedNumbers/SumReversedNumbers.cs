using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SumReversedNumbers
{
    public class SumReversedNumbers
    {
        static void Main()
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            List<int> nums = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                string element = list[i];
                string reverseElement = "";
                for (int j = element.Length - 1; j >= 0; j--)
                {
                    reverseElement += element[j];
                }

                int number = int.Parse(reverseElement);
                nums.Add(number); 
            }

            Console.WriteLine(nums.Sum());
        }
    }
}
