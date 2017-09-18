using System;

namespace _07.TrainingHallEquipment
{
    public class TrainingHallEquipment
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double subtotal = 0;

            for (int i = 0; i < n; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());

                if (itemCount == 1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                    subtotal += itemPrice;
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                    subtotal += (itemPrice * itemCount);
                }
            }

            Console.WriteLine($"Subtotal: ${subtotal:F2}");
            if (subtotal <= budget)
            {
                Console.WriteLine($"Money left: ${(budget - subtotal):F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${(subtotal - budget):F2} more.");
            }
        }
    }
}
