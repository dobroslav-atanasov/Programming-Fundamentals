using System;

namespace _01.HelloName
{
    public class HelloName
    {
        static void Main()
        {
            string name = Console.ReadLine();
            PrintHello(name);
        }

        public static void PrintHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
