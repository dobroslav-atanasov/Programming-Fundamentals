using System;

namespace _03.BackIn30Minutes
{
    public class BackIn30Minutes
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 30;
            if (minutes >= 60)
            {
                hours++;
                minutes = minutes - 60;
            }
            if (hours >= 24)
            {
                hours = hours - 24;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
