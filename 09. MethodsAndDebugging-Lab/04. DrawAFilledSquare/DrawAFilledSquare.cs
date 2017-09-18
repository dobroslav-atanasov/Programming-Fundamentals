using System;

namespace _04.DrawAFilledSquare
{
    public class DrawAFilledSquare
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderFooter(n);
            PrintBody(n);
            PrintHeaderFooter(n);
        }

        public static void PrintBody(int n)
        {
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("-");
                for (int j = 1; j <= n - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.Write("-");

                Console.WriteLine();
            }
        }

        public static void PrintHeaderFooter(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
