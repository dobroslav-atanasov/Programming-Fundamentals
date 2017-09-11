using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AndreyAndBilliard
{
    public class AndreyAndBilliard
    {
        public static void Main()
        {
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-').ToArray();
                string name = input[0];
                decimal price = decimal.Parse(input[1]);
                if (!products.ContainsKey(name))
                {
                    products[name] = 0;
                }
                products[name] = price;
            }

            List<Customer> customers = new List<Customer>();
            string tokens = Console.ReadLine();
            while (tokens != "end of clients")
            {
                string[] tokenParts = tokens.Split(new[] { ',', '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (products.ContainsKey(tokenParts[1]))
                {
                    Customer customer = new Customer
                    {
                        Name = tokenParts[0],
                        ShopList = new Dictionary<string, int>()
                    };
                    customer.ShopList.Add(tokenParts[1], int.Parse(tokenParts[2]));

                    if (customers.Any(x => x.Name == tokenParts[0]))
                    {
                        Customer exist = customers.First(x => x.Name == tokenParts[0]);
                        if (exist.ShopList.ContainsKey(tokenParts[1]))
                        {
                            exist.ShopList[tokenParts[1]] += int.Parse(tokenParts[2]);
                        }
                        else
                        {
                            exist.ShopList[tokenParts[1]] = int.Parse(tokenParts[2]);
                        }
                    }
                    else
                    {
                        customers.Add(customer);
                    }
                }
                
                tokens = Console.ReadLine();
            }

            foreach (var customer in customers)
            {
                foreach (var product in customer.ShopList)
                {
                    foreach (var price in products)
                    {
                        if (price.Key == product.Key)
                        {
                            customer.Bill += product.Value * price.Value;
                        }
                    }
                }
            }

            List<Customer> filterList = customers.OrderBy(x => x.Name).ThenBy(x => x.Bill).ToList();

            foreach (var customer in filterList)
            {
                Console.WriteLine($"{customer.Name}");
                foreach (var product in customer.ShopList)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:F2}");
            }
            Console.WriteLine($"Total bill: {customers.Sum(x => x.Bill):F2}");
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public decimal Bill { get; set; }
    }
}
