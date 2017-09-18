using System;

namespace _03.WaterOverflow
{
    public class WaterOverflow
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int litersInTank = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                litersInTank += num;

                if (num > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    litersInTank -= num;
                }
                else if (litersInTank > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    litersInTank -= num;
                }
            }

            Console.WriteLine(litersInTank);
        }
    }
}
