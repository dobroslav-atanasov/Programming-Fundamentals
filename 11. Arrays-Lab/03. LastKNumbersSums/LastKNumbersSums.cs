using System;

namespace _03.LastKNumbersSums
{
    public class LastKNumbersSums
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] nums = new long[n];
            nums[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;

                for (int j = i - 1; j >= i - k; j--)
                {
                    if (j < 0)
                    {
                        break;
                    }

                    sum += nums[j];
                }

                nums[i] = sum;
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
