using DAL.Implementations;

namespace Domain.Entities;

public class ProductCategory 
{
    public string Name { get; set; }

    public ProductCategory(string name)
    {
        Name = name;
    }
}

