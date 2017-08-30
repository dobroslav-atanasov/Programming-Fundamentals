using System;

namespace _02.ReverseArrayOfIntegers
{
    public class ReverseArrayOfIntegers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Console.Write(nums[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
