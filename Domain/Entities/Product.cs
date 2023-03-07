namespace Domain.Entities;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Product Category { get;  set; }
    public Product(string name, decimal price, Product category)
    {
        Name = name;
        Price = price;
        Category = category;
    }
}
