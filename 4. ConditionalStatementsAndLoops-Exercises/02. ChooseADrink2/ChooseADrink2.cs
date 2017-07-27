using System;

namespace _02.ChooseADrink2
{
    public class ChooseADrink2
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine($"The {profession} has to pay {(quantity * 0.70):F2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {profession} has to pay {(quantity * 1.00):F2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {profession} has to pay {(quantity * 1.70):F2}.");
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {(quantity * 1.20):F2}.");
                    break;
            }
        }
    }
}
