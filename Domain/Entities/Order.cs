using DAL.Implementations;

namespace Domain.Entities;

public class Order : OrderEntity
{
    public Order(ShoppingCart shoppingCart, Status status)
    {
        Status = status;
        Product = shoppingCart.Product;
        Client = shoppingCart.Client;
    }
}
