namespace WildBoar.Models;

public class ShoppingCart
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public int ProductId { get; set; }
    public Client Client { get; set; }
    public List<Product> Product { get; set; }
}