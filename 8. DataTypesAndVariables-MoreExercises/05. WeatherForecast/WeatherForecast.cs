using System;

namespace _05.WeatherForecast
{
    public class WeatherForecast
    {
        static void Main()
        {
            string str = Console.ReadLine();

            if (long.TryParse(str, out long number))
            {
                if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (number >= int.MinValue && number <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else if (number >= long.MinValue && number <= long.MaxValue)
                {
                    Console.WriteLine("Windy");
                }
            }
            else
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
