using System;

public class Program
{
    public static void Main()
    {
        Shop shop = new Shop();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add a new product");
            Console.WriteLine("2. Sell a product");
            Console.WriteLine("3. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter product name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter product price: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal price))
                    {
                        Console.Write("Enter product count: ");
                        if (int.TryParse(Console.ReadLine(), out int count))
                        {
                            Console.Write("Enter product type (c for Coffee, t for Tea): ");
                            string type = Console.ReadLine().ToLower();

                            if (type == "c")
                            {
                                Coffee coffee = new Coffee(name, price, count);
                                shop.AddProduct(coffee);
                            }
                            else if (type == "t")
                            {
                                Tea tea = new Tea(name, price, count);
                                shop.AddProduct(tea);
                            }
                            else
                            {
                                Console.WriteLine("Invalid product type. Please enter 'c' for Coffee or 't' for Tea.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid count. Please enter a valid integer.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid price. Please enter a valid decimal number.");
                    }
                    break;

                case "2":
                    Console.Write("Enter product name to sell: ");
                    string productName = Console.ReadLine();
                    Console.Write("Enter product count to sell: ");
                    if (int.TryParse(Console.ReadLine(), out int sellCount))
                    {
                        shop.SellProduct(productName, sellCount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid count. Please enter a valid integer.");
                    }
                    break;

                case "3":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    break;
            }
        }
    }
}
