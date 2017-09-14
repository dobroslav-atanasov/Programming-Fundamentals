using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _03.EqualSums
{
    public class EqualSums
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines(@"..\..\Input.txt");

            int[] array = input[0].Split(' ').Select(int.Parse).ToArray();

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j <= i; j++)
                {
                    leftSum += array[j];
                }
                for (int k = array.Length - 1; k >= i; k--)
                {
                    rightSum += array[k];
                }
                if (leftSum == rightSum)
                {
                    var result = i;
                    File.WriteAllText(@"..\..\Output.txt", result.ToString());
                    count = 1;
                }
                if (count == 0)
                {
                    var result = "no";
                    File.WriteAllText(@"..\..\Output.txt", result);
                }
            }
        }
    }
}
