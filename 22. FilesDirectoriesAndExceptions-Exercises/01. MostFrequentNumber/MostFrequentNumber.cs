using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _01.MostFrequentNumber
{
    public class MostFrequentNumber
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines(@"..\..\Input.txt");

            int[] array = input[0].Split(' ').Select(int.Parse).ToArray();

            int number = 0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int tempcounter = 0;

                foreach (var item in array)
                {
                    if (array[i] == item)
                    {
                        tempcounter++;
                    }
                    if (tempcounter > count)
                    {
                        number = array[i];
                        count = tempcounter;
                    }
                }
            }

            File.WriteAllText(@"..\..\Output.txt", number.ToString());
        }
    }
}
