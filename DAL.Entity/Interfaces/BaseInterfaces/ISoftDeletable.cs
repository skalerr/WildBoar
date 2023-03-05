namespace DAL.Interfaces.BaseInterfaces
{
    public interface ISoftDeletable
    {
        bool IsDeleted { get; set; }
        DateTime? DeleteDate { get; set; }
    }
}
