using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.EmailMe
{
    public class EmailMe
    {
        public static void Main()
        {
            string email = Console.ReadLine();
            int index = email.IndexOf('@');
            string firstPart = email.Substring(0, index);
            string secondPart = email.Substring(index + 1);
            int firstSum = 0;
            int secondSum = 0;

            for (int i = 0; i < firstPart.Length; i++)
            {
                firstSum += firstPart[i];
            }
            for (int i = 0; i < secondPart.Length; i++)
            {
                secondSum += secondPart[i];
            }

            int subtract = secondSum - firstSum;
            Console.WriteLine(subtract <= 0 ? "Call her!" : "She is not the one.");
        }
    }
}
