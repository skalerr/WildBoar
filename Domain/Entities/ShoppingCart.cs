
namespace Domain.Entities;

public class ShoppingCart
{
    public Client Client { get; set; }
    public List<Product> Product { get; set; }
    public decimal Price { get { return Product.Sum(item => item.Price); }}
    public ShoppingCart(List<Product> product, Client client)
    {
        Client = client;
        Product = product;
    }
}
