using System;

namespace _04.Elevator
{
    public class Elevator
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)n / p);

            Console.WriteLine(courses);
        }
    }
}
