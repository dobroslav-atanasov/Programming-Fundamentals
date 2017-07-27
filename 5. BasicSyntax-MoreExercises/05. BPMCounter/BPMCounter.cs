using System;

namespace _05.BPMCounter
{
    public class BPMCounter
    {
        static void Main()
        {
            double beatsPerMinute = double.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());

            double bars = numberOfBeats / 4;
            double seconds = 60 * (numberOfBeats / beatsPerMinute);

            var timespan = TimeSpan.FromSeconds(seconds);
            Console.WriteLine($"{Math.Round(bars, 1)} bars - {timespan.Minutes}m {timespan.Seconds}s"); 
        }
    }
}
