using System;
using System.Linq;

namespace _02.RotateAndSum
{
    public class RotateAndSum
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] sum = new int[nums.Length];

            for (int i = 0; i < k; i++)
            {
                int lastElement = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j > 0; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = lastElement;

                for (int j = 0; j < nums.Length; j++)
                {
                    sum[j] += nums[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
