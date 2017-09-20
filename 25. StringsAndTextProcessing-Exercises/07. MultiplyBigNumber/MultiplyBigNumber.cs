using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _07.MultiplyBigNumber
{
    public class MultiplyBigNumber
    {
        public static void Main()
        {
            BigInteger first = BigInteger.Parse(Console.ReadLine());
            BigInteger second = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(first * second);
        }
    }
}
