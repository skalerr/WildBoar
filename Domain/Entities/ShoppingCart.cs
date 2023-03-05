using DAL.Implementations;

namespace Domain.Entities;

public class ShoppingCart : ShoppingCartEntity
{
    public ShoppingCart(List<ProductEntity> product, Client client)
    {
        Client = client;
        Product = product;
    }
}
