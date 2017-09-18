using System;

namespace _07.CakeIngredients
{
    public class CakeIngredients
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int count = 0;

            while (!input.Equals("Bake!"))
            {
                Console.WriteLine($"Adding ingredient {input}.");
                count++;

                input = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
