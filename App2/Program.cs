using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);
            Product maxProduct = products[0];
            foreach (Product p in products)
            {
                if (p.Price > maxProduct.Price)
                {
                    maxProduct = p;
                }
            }
            Console.WriteLine($"{maxProduct.Code} {maxProduct.Name} {maxProduct.Price}");
            Console.ReadKey();
        }
    }
}
