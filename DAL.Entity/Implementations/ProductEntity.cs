using DAL.Interfaces;
using Domain.Entites.BaseEntity;

namespace DAL.Implementations;

public class ProductEntity : BaseEntity<long>, IAuditable
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public ProductEntityCategory Category { get;  set; }
    
    public bool IsDeleted { get; set; }
    public DateTime? DeleteDate { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
}
