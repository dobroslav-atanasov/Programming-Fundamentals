using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.JumpAround
{
    public class JumpAround
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            long sum = array[0];
            int index = 0;
            int element = array[0];

            while (true)
            {
                if (element + index < array.Length)
                {
                    index += element;
                    element = array[index];
                    sum += element;
                }
                else if (index - element >= 0)
                {
                    index -= element;
                    element = array[index];
                    sum += element;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
