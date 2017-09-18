using System;

namespace _15.BalancedBrackets
{
    public class BalancedBrackets
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int countFirst = 0;
            int countSecond = 0;
            string previus = "";
            bool isUnbalanced = false;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input.Equals("(") || input.Equals(")"))
                {
                    if (previus == input)
                    {
                        isUnbalanced = true;
                    }
                    if (input.Equals("("))
                    {
                        countFirst++;
                    }
                    else
                    {
                        countSecond++;
                    }

                    previus = input;
                }                
            }

            if (isUnbalanced)
            {
                Console.WriteLine("UNBALANCED");
            }
            else if (countFirst == countSecond)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
