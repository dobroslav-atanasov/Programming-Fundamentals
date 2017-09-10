using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _03.BigFactorial
{
    public class BigFactorial
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
