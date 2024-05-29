using System;
using System.Collections.Generic;
using System.Linq;

public class Shop
{
    private List<Product> products;
    public decimal TotalIncome { get; private set; }

    public Shop()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        if (!products.Any(p => p.Name == product.Name))
        {
            products.Add(product);
            Console.WriteLine($"Product '{product.Name}' added.");
        }
        else
        {
            Console.WriteLine($"A product with the same name '{product.Name}' already exists and was not added.");
        }
    }

    public void SellProduct(string name, int count)
    {
        Product product = products.FirstOrDefault(p => p.Name == name);
        if (product != null)
        {
            if (product.Count >= count)
            {
                TotalIncome += product.Price * count;
                product.Count -= count;
                Console.WriteLine($"Sold {count} units of '{name}'. Total income: {TotalIncome}");
            }
            else
            {
                Console.WriteLine($"Not enough stock for product '{name}'.");
            }
        }
        else
        {
            Console.WriteLine($"Product '{name}' not found.");
        }
    }
}
