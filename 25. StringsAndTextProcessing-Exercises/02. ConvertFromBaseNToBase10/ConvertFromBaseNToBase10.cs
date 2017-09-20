using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _02.ConvertFromBaseNToBase10
{
    public class ConvertFromBaseNToBase10
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int @base = int.Parse(input[0]);
            char[] num = input[1].Reverse().ToArray();

            BigInteger sum = 0;
            for (int power = 0; power < num.Length; power++)
            {
                int digit = int.Parse(num[power].ToString());
                sum += digit * BigInteger.Pow(@base, power);
            }

            Console.WriteLine(sum);
        }
    }
}
