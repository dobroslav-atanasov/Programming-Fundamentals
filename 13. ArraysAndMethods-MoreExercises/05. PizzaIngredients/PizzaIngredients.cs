using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PizzaIngredients
{
    public class PizzaIngredients
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            int length = int.Parse(Console.ReadLine());

            List<string> pizza = new List<string>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length == length)
                {
                    pizza.Add(array[i]);
                    Console.WriteLine($"Adding {array[i]}.");
                }
                if (pizza.Count == 10)
                {
                    break;
                }
            }

            Console.WriteLine($"Made pizza with total of {pizza.Count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", pizza)}.");
        }
    }
}
