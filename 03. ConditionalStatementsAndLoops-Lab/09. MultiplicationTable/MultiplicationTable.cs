using System;

namespace _09.MultiplicationTable
{
    public class MultiplicationTable
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
        }
    }
}
