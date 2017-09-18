using System;

namespace _03.RestaurantDiscount
{
    public class RestaurantDiscount
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            if (groupSize <= 50)
            {
                if (package.Equals("Normal"))
                {
                    decimal totalPrice = 2500 + 500;
                    decimal discount = totalPrice * 0.05m;
                    totalPrice -= discount;
                    decimal pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package.Equals("Gold"))
                {
                    decimal totalPrice = 2500 + 750;
                    decimal discount = totalPrice * 0.10m;
                    totalPrice -= discount;
                    decimal pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package.Equals("Platinum"))
                {
                    decimal totalPrice = 2500 + 1000;
                    decimal discount = totalPrice * 0.15m;
                    totalPrice -= discount;
                    decimal pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                if (package.Equals("Normal"))
                {
                    decimal totalPrice = 5000 + 500;
                    decimal discount = totalPrice * 0.05m;
                    totalPrice -= discount;
                    decimal pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package.Equals("Gold"))
                {
                    decimal totalPrice = 5000 + 750;
                    decimal discount = totalPrice * 0.10m;
                    totalPrice -= discount;
                    decimal pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package.Equals("Platinum"))
                {
                    decimal totalPrice = 5000 + 1000;
                    decimal discount = totalPrice * 0.15m;
                    totalPrice -= discount;
                    decimal pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                if (package.Equals("Normal"))
                {
                    decimal totalPrice = 7500 + 500;
                    decimal discount = totalPrice * 0.05m;
                    totalPrice -= discount;
                    decimal pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package.Equals("Gold"))
                {
                    decimal totalPrice = 7500 + 750;
                    decimal discount = totalPrice * 0.10m;
                    totalPrice -= discount;
                    decimal pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package.Equals("Platinum"))
                {
                    decimal totalPrice = 7500 + 1000;
                    decimal discount = totalPrice * 0.15m;
                    totalPrice -= discount;
                    decimal pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
