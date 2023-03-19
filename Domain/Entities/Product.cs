using DAL.Implementations;

namespace Domain.Entities;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public ProductEntityCategory Category { get;  set; }
    
    public Product(string name, decimal price, ProductEntityCategory category)
    {
        Name = name;
        Price = price;
        Category = category;
    }
}
