using System;

namespace _13.GameOfNumbers
{
    public class GameOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int count = 0;
            int firstNumber = 0;
            int secondNumber = 0;
            bool isFound = false;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if ((i + j) == magicNumber)
                    {
                        firstNumber = i;
                        secondNumber = j;
                        isFound = true;
                    }
                    else
                    {
                        count++;
                    }
                }
            }

            if (isFound)
            {
                Console.WriteLine($"Number found! {firstNumber} + {secondNumber} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
        }
    }
}
