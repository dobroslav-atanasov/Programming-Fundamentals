using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _04.MaxSequenceOfEqualElements
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var input = File.ReadAllLines(@"..\..\Input.txt");

            var array = input[0].Split(' ').Select(int.Parse).ToArray();

            var length = 1;
            var start = 0;
            var bestLength = 1;
            var bestStart = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    start = array[i];
                    length++;
                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                }
                else
                {
                    length = 1;
                    start = array[i];
                }
            }

            var result = new int[bestLength];
            for (int i = 0; i < bestLength; i++)
            {
                result[i] = bestStart;
                //File.AppendAllText("output.txt", result[i] + " ");
            }

            var final = string.Join(" ", result);
            File.WriteAllText(@"..\..\Output.txt", final);
        }
    }
}
