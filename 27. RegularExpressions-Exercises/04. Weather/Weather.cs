using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    public class Weather
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, WeatherInfo> towns = new Dictionary<string, WeatherInfo>();
            string pattern = @"([A-Z]{2})(\d+\.\d+)([A-z]+)(\|)";

            while (input != "end")
            {
                MatchCollection matches = Regex.Matches(input, pattern);
                foreach (Match match in matches)
                {
                    string town = match.Groups[1].Value;
                    double temperature = double.Parse(match.Groups[2].Value);
                    string type = match.Groups[3].Value;
                    WeatherInfo weatherInfo = new WeatherInfo()
                    {
                        Temperature = temperature,
                        Type = type
                    };

                    if (!towns.ContainsKey(town))
                    {
                        towns[town] = null;
                    }
                    towns[town] = weatherInfo;
                }
                input = Console.ReadLine();
            }

            foreach (var town in towns.OrderBy(x => x.Value.Temperature))
            {
                Console.WriteLine($"{town.Key} => {town.Value.Temperature} => {town.Value.Type}");
            }
        }
    }

    public class WeatherInfo
    {
        public double Temperature { get; set; }
        public string Type { get; set; }
    }
}
