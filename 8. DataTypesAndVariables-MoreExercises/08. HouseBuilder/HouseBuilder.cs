using System;

namespace _08.HouseBuilder
{
    public class HouseBuilder
    {
        static void Main()
        {
            long first = long.Parse(Console.ReadLine());
            long second = long.Parse(Console.ReadLine());

            long totalPrice = 0;

            if (first >= sbyte.MinValue && first <= sbyte.MaxValue)
            {
                totalPrice += (4 * first) + (10 * second);
            }
            else
            {
                totalPrice += (4 * second) + (10 * first);
            }

            Console.WriteLine(totalPrice);
        }
    }
}
