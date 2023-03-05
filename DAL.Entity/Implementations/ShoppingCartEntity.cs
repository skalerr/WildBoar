using DAL.Interfaces;
using Domain.Entites.BaseEntity;
using WildBoar.Models;

namespace DAL.Implementations;

public class ShoppingCartEntity : BaseEntity<long>, IAuditable
{
    
    public int Id { get; set; }
    public int ClientId { get; set; }
    public int ProductId { get; set; }
    public ClientEntity Client { get; set; }
    public List<ProductEntity> Product { get; set; }
    
    public bool IsDeleted { get; set; }
    public DateTime? DeleteDate { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
}