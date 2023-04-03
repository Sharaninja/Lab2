using System;
using System.Collections.Generic;
using System.Linq;
using laaab2;

class Program
{
    static void Main(string[] args)
    {
        
        var products = new List<Product>
        {
            new Product { Name = "Product A", Category = "Category 1", Price = 10 },
            new Product { Name = "Product B", Category = "Category 1", Price = 20 },
            new Product { Name = "Product C", Category = "Category 2", Price = 15 },
            new Product { Name = "Product D", Category = "Category 2", Price = 25 },
            new Product { Name = "Product E", Category = "Category 3", Price = 30 }
        };

        
        var groupedProducts = products.GroupBy(p => p.Category);

        
        foreach (var group in groupedProducts)
        {
            Console.WriteLine(group.Key + ":");
            foreach (var product in group)
            {
                Console.WriteLine("- " + product.Name);
            }
        }
    }
}


