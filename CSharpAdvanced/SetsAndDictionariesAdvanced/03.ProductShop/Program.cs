using System;
using System.Collections.Generic;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            string command = Console.ReadLine();

            while (command?.ToUpper() != "REVISION")
            {
                string[] tokens = command.Split(", ");

                string currentShop = tokens[0];
                string currentProduct = tokens[1];
                double currentProductPrice = double.Parse(tokens[2]);

                if (!shops.ContainsKey(currentShop))
                {
                    shops.Add(currentShop, new Dictionary<string, double>());
                }

                shops[currentShop].Add(currentProduct, currentProductPrice);

                command = Console.ReadLine();
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
