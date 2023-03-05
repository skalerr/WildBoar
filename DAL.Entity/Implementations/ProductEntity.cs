using DAL.Interfaces;
using Domain.Entites.BaseEntity;

namespace DAL.Implementations;

public class ProductEntity : BaseEntity<long>, IAuditable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    
    public bool IsDeleted { get; set; }
    public DateTime? DeleteDate { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
}

public enum Category
{
    Food,
    Clothes,
    Electronics,
    Other
}