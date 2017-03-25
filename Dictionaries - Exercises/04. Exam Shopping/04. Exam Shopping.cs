using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Exam_Shopping
{
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var products = new Dictionary<string, int>();
            line = AddToInventory(line, products);
            line = BuyFromInventory(line, products);
            foreach (var productQuantityPair in products)
            {
                if (productQuantityPair.Value > 0)
                {
                    Console.WriteLine($"{productQuantityPair.Key} -> {productQuantityPair.Value}");
                }
            }
        }

        private static string BuyFromInventory(string line, Dictionary<string, int> products)
        {
            while (line != "exam time")
            {
                var tokens = line.Split(' ');
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
                line = Console.ReadLine();
            }

            return line;
        }

        private static string AddToInventory(string line, Dictionary<string, int> products)
        {
            while (line != "shopping time")
            {
                var tokens = line.Split(' ');
                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);
                if (!products.ContainsKey(product))
                {
                    products[product] = 0;
                }
                products[product] += quantity;
                line = Console.ReadLine();
            }
            line = Console.ReadLine();
            return line;
        }
    }
}
