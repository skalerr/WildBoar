using DAL.Implementations;

namespace Domain.Entities;

public class Product : ProductEntity
{
    public Product(string name, decimal price, ProductEntityCategory category)
    {
        Name = name;
        Price = price;
        Category = category;
    }
}
