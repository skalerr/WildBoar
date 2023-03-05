namespace Domain.Entites.BaseEntity;

public abstract class BaseEntity<T>
{
    public T Id { get; set; }
}