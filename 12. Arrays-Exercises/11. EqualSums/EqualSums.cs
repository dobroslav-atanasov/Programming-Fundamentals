using System;
using System.Linq;

namespace _11.EqualSums
{
    public class EqualSums
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool isValid = false;
            int position = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                position = i;

                for (int left = 0; left < position; left++)
                {
                    leftSum += array[left];
                }
                for (int right = position + 1; right < array.Length; right++)
                {
                    rightSum += array[right];
                }

                if (leftSum == rightSum)
                {
                    isValid = true;
                    break;
                }
            }

            if (isValid)
            {
                Console.WriteLine(position);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
