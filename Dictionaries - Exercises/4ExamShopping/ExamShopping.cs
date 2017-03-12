using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ExamShopping
{
    class ExamShopping
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, int>();
            var input = Console.ReadLine();

            while (input != "shopping time")
            {
                var tokens = input.Split();
                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);

                if (!products.ContainsKey(product))
                {
                    products[product] = 0;
                }
                products[product] += quantity;

                input = Console.ReadLine();
            }
            while (input != "exam time")
            {
                if (input == "shopping time")
                {
                    input = Console.ReadLine();
                }
                var tokens = input.Split();
                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);

                if (!products.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                {
                    if (products[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        products[product] -= quantity;

                        if (products[product] < 0)
                        {
                            products[product] = 0;
                        }
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var productQuantityPair in products)
            {
                var product = productQuantityPair.Key;
                var quantity = productQuantityPair.Value;
                if (quantity > 0)
                {
                    Console.WriteLine($"{product} -> {quantity}");
                }
            }
        }
    }
}
