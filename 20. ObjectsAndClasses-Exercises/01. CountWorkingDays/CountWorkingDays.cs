using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _01.CountWorkingDays
{
    public class CountWorkingDays
    {
        public static void Main()
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            List<DateTime> holidays = new List<DateTime>();
            holidays.Add(new DateTime(2016, 01, 01));
            holidays.Add(new DateTime(2016, 03, 03));
            holidays.Add(new DateTime(2016, 05, 01));
            holidays.Add(new DateTime(2016, 05, 06));
            holidays.Add(new DateTime(2016, 05, 24));
            holidays.Add(new DateTime(2016, 09, 06));
            holidays.Add(new DateTime(2016, 09, 22));
            holidays.Add(new DateTime(2016, 11, 01));
            holidays.Add(new DateTime(2016, 12, 24));
            holidays.Add(new DateTime(2016, 12, 25));
            holidays.Add(new DateTime(2016, 12, 26));

            int workDays = 0;
            for (DateTime day = startDate; day <= endDate; day = day.AddDays(1))
            {
                DateTime temp = new DateTime(2016, day.Month, day.Day);
                if (!(holidays.Contains(temp)) && !(day.DayOfWeek == DayOfWeek.Saturday) && !(day.DayOfWeek == DayOfWeek.Sunday))
                {
                    workDays++;
                }
            }

            Console.WriteLine(workDays);
        }
    }
}
