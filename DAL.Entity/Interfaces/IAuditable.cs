using DAL.Interfaces.BaseInterfaces;

namespace DAL.Interfaces;

/// <summary>
/// Ис
/// </summary>
public interface IAuditable : ISoftDeletable, ICreateDate, IUpdateDate
{
    public bool IsDeleted { get; set; }
    public DateTime? DeleteDate { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
}