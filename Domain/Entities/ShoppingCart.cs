namespace Domain.Entities;

public class ShoppingCart 
{
    public Client Client { get; set; }
    public List<Product> Product { get; set; }
    public ShoppingCart(List<Product> product, Client client)
    {
        Client = client;
        Product = product;
    }
}
