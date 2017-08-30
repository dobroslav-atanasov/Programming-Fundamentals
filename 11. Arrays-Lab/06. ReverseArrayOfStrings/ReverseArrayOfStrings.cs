using System;
using System.Linq;

namespace _06.ReverseArrayOfStrings
{
    public class ReverseArrayOfStrings
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < array.Length / 2; i++)
            {
                string temp = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = array[i];
                array[i] = temp;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
