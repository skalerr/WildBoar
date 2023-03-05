using DAL.Implementations;

namespace Domain.Entities;

public class ShoppingCart : ShoppingCartEntity
{
    public ShoppingCart(List<Product> product, Client client)
    {
        Client = client;
        Product = product;
    }
}
