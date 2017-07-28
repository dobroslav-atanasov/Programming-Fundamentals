using System;

namespace _19.TheaThePhotographer
{
    public class TheaThePhotographer
    {
        static void Main()
        {
            int numberOfPictures = int.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            double percent = filterFactor / 100.0;
            long filtered = (long)Math.Ceiling(numberOfPictures * percent);
            long totalTime = numberOfPictures * filterTime + filtered * uploadTime;

            TimeSpan ts = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine($"{ts.Days:D1}:{ts.Hours:D2}:{ts.Minutes:D2}:{ts.Seconds:D2}");
        }
    }
}
