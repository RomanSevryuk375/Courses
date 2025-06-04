using System;
using System.Collections.Generic;

namespace H9_T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productsDictionary = new Dictionary<string, double>();
            productsDictionary.Add("dumplings", 11.51);
            productsDictionary.Add("milk", 2.51);
            productsDictionary.Add("coffee", 51.5);

            foreach (var product in productsDictionary)
            {
                Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
            }

            Console.WriteLine("Enter product");
            var productName = Console.ReadLine().ToLower().Trim();
            if (productsDictionary.ContainsKey(productName))
            {
                Console.WriteLine($"Product: {productName}, Price: {productsDictionary[productName]}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Product not found");
            }

            Console.WriteLine("Raised for 10%");
            foreach (var product in productsDictionary)
            {
                Console.WriteLine($"Product: {product.Key}, Nem Price: {(product.Value + product.Value * 0.1):N2}");
            }
        }
    }
}

