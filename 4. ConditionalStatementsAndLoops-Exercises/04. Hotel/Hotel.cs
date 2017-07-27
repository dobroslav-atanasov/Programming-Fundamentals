using System;

namespace _04.Hotel
{
    public class Hotel
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());

            if (month.Equals("May") || month.Equals("October"))
            {
                decimal studioPerNight = 50;
                decimal doublePerNight = 65;
                decimal suitePerNight = 75;

                decimal priceStudio = studioPerNight * nightCount;
                decimal priceDouble = doublePerNight * nightCount;
                decimal priceSuite = suitePerNight * nightCount;

                if (month.Equals("October") && nightCount > 7)
                {
                    priceStudio -= studioPerNight;
                }
                if (nightCount > 7)
                {
                    priceStudio = priceStudio - (priceStudio * 0.05m);
                }

                Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                Console.WriteLine($"Double: {priceDouble:F2} lv.");
                Console.WriteLine($"Suite: {priceSuite:F2} lv.");
            }
            else if (month.Equals("June") || month.Equals("September"))
            {
                decimal studioPerNight = 60;
                decimal doublePerNight = 72;
                decimal suitePerNight = 82;

                decimal priceStudio = studioPerNight * nightCount;
                decimal priceDouble = doublePerNight * nightCount;
                decimal priceSuite = suitePerNight * nightCount;

                if (month.Equals("September") && nightCount > 7)
                {
                    priceStudio -= studioPerNight;
                }
                if (nightCount > 14)
                {
                    priceDouble = priceDouble - (priceDouble * 0.10m);
                }

                Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                Console.WriteLine($"Double: {priceDouble:F2} lv.");
                Console.WriteLine($"Suite: {priceSuite:F2} lv.");
            }
            else if (month.Equals("July") || month.Equals("August") || month.Equals("December"))
            {
                decimal studioPerNight = 68;
                decimal doublePerNight = 77;
                decimal suitePerNight = 89;

                decimal priceStudio = studioPerNight * nightCount;
                decimal priceDouble = doublePerNight * nightCount;
                decimal priceSuite = suitePerNight * nightCount;

                if (nightCount > 14)
                {
                    priceSuite = priceSuite - (priceSuite * 0.15m);
                }

                Console.WriteLine($"Studio: {priceStudio:F2} lv.");
                Console.WriteLine($"Double: {priceDouble:F2} lv.");
                Console.WriteLine($"Suite: {priceSuite:F2} lv.");
            }
        }
    }
}
