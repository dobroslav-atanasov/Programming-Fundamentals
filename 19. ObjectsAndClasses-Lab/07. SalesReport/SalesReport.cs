using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SalesReport
{
    public class SalesReport
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, decimal> townPrice = new SortedDictionary<string, decimal>();
            List<Sale> list = new List<Sale>();    
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Sale sale = new Sale
                {
                    Town = input[0],
                    Product = input[1],
                    Price = decimal.Parse(input[2]),
                    Quantity = decimal.Parse(input[3])
                };

                if (!townPrice.ContainsKey(sale.Town))
                {
                    townPrice[sale.Town] = 0;
                }
                townPrice[sale.Town] += sale.TotalPrice;
                list.Add(sale);
            }

            foreach (var town in townPrice)
            {
                Console.WriteLine($"{town.Key} -> {(town.Value):F2}");
            }            
        }
    }

    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get { return Price * Quantity; } }
    }
}
