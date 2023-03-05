using DAL.Implementations;

namespace Domain.Entities;

public class Product : ProductEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Role { get; set; }
}