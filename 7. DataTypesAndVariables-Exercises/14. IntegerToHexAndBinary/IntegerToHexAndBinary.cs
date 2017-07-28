using System;

namespace _14.IntegerToHexAndBinary
{
    public class IntegerToHexAndBinary
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            string hexadecimal = Convert.ToString(num, 16).ToUpper();
            string binary = Convert.ToString(num, 2);

            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);
        }
    }
}
