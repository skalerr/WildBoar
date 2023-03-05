namespace WildBoar.Models;

public class Client : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Role { get; set; }
    public List<ShoppingCart> ShoppingCart { get; set; }
}