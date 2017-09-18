using System;

namespace _06.IntervalOfNumbers
{
    public class IntervalOfNumbers
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int smaller = 0;
            int bigger = 0;

            if (start < end)
            {
                smaller = start;
                bigger = end;
            }
            else
            {
                smaller = end;
                bigger = start;
            }

            for (int i = smaller; i <= bigger; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
