public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }

    public Product(string name, decimal price, int count)
    {
        Name = name;
        Price = price;
        Count = count;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price}, Count: {Count}";
    }
}
