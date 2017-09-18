using System;

namespace _11.ConvertSpeedUnits
{
    public class ConvertSpeedUnits
    {
        static void Main()
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float meterPerSecond = distance / (float)(hours * 3600 + minutes * 60 + seconds);
            float kph = (distance / 1000) / (float)(hours + minutes / 60.0 + seconds / 3600.0);
            float mph = (distance / 1609.0f) / (float)(hours + minutes / 60.0 + seconds / 3600.0);
            Console.WriteLine($"{meterPerSecond}");
            Console.WriteLine($"{kph}");
            Console.WriteLine($"{mph}");
        }
    }
}
