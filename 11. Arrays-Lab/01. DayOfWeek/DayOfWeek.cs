using System;

namespace _01.DayOfWeek
{
    public class DayOfWeek
    {
        static void Main()
        {
            var day = int.Parse(Console.ReadLine());

            var daysOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(daysOfWeek[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
