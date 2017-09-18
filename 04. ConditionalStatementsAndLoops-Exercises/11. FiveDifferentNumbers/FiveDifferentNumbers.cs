using System;

namespace _11.FiveDifferentNumbers
{
    public class FiveDifferentNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if ((b - a) < 4)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = i + 1; j <= b; j++)
                    {
                        for (int k = j + 1; k <= b; k++)
                        {
                            for (int l = k + 1; l <= b; l++)
                            {
                                for (int m = l + 1; m <= b; m++)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }
                            }
                        }
                    }
                }
            }            
        }
    }
}
