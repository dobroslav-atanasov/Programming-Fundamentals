using System;

namespace _10.MultiplicationTable2._0
{
    public class MultiplicationT
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());

            if (start > 10)
            {
                Console.WriteLine($"{n} X {start} = {n * start}");
            }
            else
            {
                for (int i = start; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }            
        }
    }
}
