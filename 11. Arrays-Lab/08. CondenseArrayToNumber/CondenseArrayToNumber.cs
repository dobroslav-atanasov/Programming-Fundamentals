using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    public class CondenseArrayToNumber
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] result = new int[array.Length - 1];

            while (array.Length > 1)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = array[i] + array[i + 1];
                }

                array = result;
                Array.Resize<int>(ref result, array.Length - 1); 
            }

            Console.WriteLine(array[0]);
        }
    }
}
