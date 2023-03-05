using DAL.Implementations;
using DAL.Interfaces;
using Domain.Entites.BaseEntity;

namespace WildBoar.Models;

public class ClientEntity : BaseEntity<long>, IAuditable
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Role { get; set; }
    
    public List<ShoppingCartEntity> ShoppingCart { get; set; }

    
    public DateTime? UpdateDate { get; set; }
    public DateTime CreateDate { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeleteDate { get; set; }

}