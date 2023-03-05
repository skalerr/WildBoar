using DAL.Interfaces;
using Domain.Entites.BaseEntity;
using WildBoar.Models;

namespace DAL.Implementations;

public class OrderEntity : BaseEntity<long>, IAuditable
{
    public Status Status { get; set; }
    public List<ProductEntity> Product { get; set; }
    public decimal Price { get { return Product.Sum(item => item.Price); }}
    public ClientEntity Client { get; set; }
    
    public bool IsDeleted { get; set; }
    public DateTime? DeleteDate { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
}
public enum Status
{
    Active,
    Сlose,
    Сancel
}