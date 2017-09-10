using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _01.DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
