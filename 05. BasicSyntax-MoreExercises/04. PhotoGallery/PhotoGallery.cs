using System;

namespace _04.PhotoGallery
{
    public class PhotoGallery
    {
        static void Main()
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string textDay = "";
            if (day < 10)
            {
                textDay = $"{day:D2}";
            }
            else
            {
                textDay += day;
            }

            string textMonth = "";
            if (month < 10)
            {
                textMonth = $"{month:D2}";
            }
            else
            {
                textMonth += month;
            }

            string textHours = "";
            if (hours < 10)
            {
                textHours = $"{hours:D2}";
            }
            else
            {
                textHours += hours;
            }

            string textMinutes = "";
            if (minutes < 10)
            {
                textMinutes = $"{minutes:D2}";
            }
            else
            {
                textMinutes += minutes;
            }

            double readSize = 0;
            string textSize = "";
            if (size < 1000)
            {
                readSize = size;
                textSize = size + "B";
            }
            else if (size >= 1000 && size < 1_000_000)
            {
                readSize = size / 1000;
                textSize = readSize + "KB";
            }
            else if (size >= 1_000_000)
            {
                readSize = Math.Round(size / 1_000_000.0, 1);
                textSize = readSize + "MB";
            }

            string orientation = "";
            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }
            else if (width == height)
            {
                orientation = "square";
            }
            
            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {textDay}/{textMonth}/{year} {textHours}:{textMinutes}");
            Console.WriteLine($"Size: {textSize}");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");

        }
    }
}
