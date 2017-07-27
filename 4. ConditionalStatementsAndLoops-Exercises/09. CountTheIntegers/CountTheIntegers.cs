using System;

namespace _09.CountTheIntegers
{
    public class CountTheIntegers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int count = 0;

            while (true)
            {
                int num = 0;
                bool result = int.TryParse(input, out num);
                if (result)
                {
                    count++;
                }
                else
                {
                    break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(count);
        }
    }
}
