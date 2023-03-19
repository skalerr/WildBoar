using DAL.Enums;
using DAL.Implementations;

namespace Domain.Entities;

public class Order
{
    public Status Status { get; set; }
    public List<Product> Product { get; set; }
    public decimal Price { get { return Product.Sum(item => item.Price); }}
    public Client Client { get; set; }
    
    public Order(ShoppingCart shoppingCart, Status status)
    {
        Status = status;
        Product = shoppingCart.Product;
        Client = shoppingCart.Client;
    }
}
