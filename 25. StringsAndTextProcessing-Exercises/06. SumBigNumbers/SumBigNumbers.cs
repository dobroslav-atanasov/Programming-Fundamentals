using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _06.SumBigNumbers
{
    public class SumBigNumbers
    {
        public static void Main()
        {
            BigInteger first = BigInteger.Parse(Console.ReadLine());
            BigInteger second = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(first + second);
        }
    }
}
