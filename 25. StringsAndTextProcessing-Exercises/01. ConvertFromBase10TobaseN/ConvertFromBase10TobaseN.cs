using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _01.ConvertFromBase10TobaseN
{
    public class ConvertFromBase10TobaseN
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int @base = int.Parse(input[0]);
            BigInteger num = BigInteger.Parse(input[1]);
            StringBuilder numbers = new StringBuilder();

            while (num > 0)
            {
                var digit = num % @base;

                numbers.Append(digit);
                num /= @base;
            }

            var result = new string(numbers.ToString().Reverse().ToArray());
            Console.WriteLine(result);
        }
    }
}
