using System;

namespace _01.LargestCommonEnd
{
    public class LargestCommonEnd
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            int count = 0;

            if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i].Equals(secondArray[i]))
                    {
                        count++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
                {
                    if (firstArray[i].Equals(secondArray[i]))
                    {
                        count++;
                    }
                }

                for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
                {
                    if (firstArray[firstArray.Length - 1 -i].Equals(secondArray[secondArray.Length - 1 - i]))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
