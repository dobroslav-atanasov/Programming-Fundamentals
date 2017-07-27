using System;

namespace _01.X
{
    public class X
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int firstPart = (n - 1) / 2;

            int space = 0;
            int middleSpace = n - 2;
            for (int i = 1; i <= firstPart; i++)
            {
                Console.WriteLine(new string(' ', space) + "x" + new string(' ', middleSpace) + "x" + new string(' ', space));
                space++;
                middleSpace -= 2;
            }

            Console.WriteLine(new string(' ', firstPart) + "x");

            space--;
            middleSpace += 2;
            for (int i = 1; i <= firstPart; i++)
            {
                Console.WriteLine(new string(' ', space) + "x" + new string(' ', middleSpace) + "x" + new string(' ', space));
                space--;
                middleSpace += 2;
            }
        }
    }
}
