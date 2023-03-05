using Domain.Entites.BaseEntity;

namespace DAL.Repositories.Interface
{
    public interface IRepository<T> where T : BaseEntity<T>
    {
        T FindById (int id);

        IEnumerable<T> FindAll();

        bool Create (T entity);
        
        bool Update (T entity);

        bool Delete (T entity);

        bool Save();
    }
}
