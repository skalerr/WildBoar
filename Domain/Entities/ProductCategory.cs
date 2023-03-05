using DAL.Implementations;

namespace Domain.Entities;

public class ProductCategory : ProductEntityCategory 
{
    public ProductCategory(string name)
    {
        Name = name;
    }
}

