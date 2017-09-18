using System;

namespace _02.AddTwoNumbers
{
    public class AddTwoNumbers
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;

            Console.WriteLine($"{num1} + {num2} = {sum}");
        }
    }
}
