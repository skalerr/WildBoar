using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EntityFramework.DB;
using DAL.Interfaces.BaseInterfaces;
using DAL.Repositories.Interface;
using Domain.Entites.BaseEntity;

namespace DAL.EntityFramework.Repository.EfRepository
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity<T>
    {
        private readonly AppEfContext _db;

        public EfRepository(AppEfContext db)
        {
            _db = db;
        }
        public bool Create(T entity)
        {
            try
            {
                _db.Set<T>().Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        

        public bool Delete(T entity)
        {
            try
            {
                if (entity is ISoftDeletable)
                { 
                    ((ISoftDeletable)entity).IsDeleted = true;
                }
                else 
                    _db.Set<T>().Remove(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<T> FindAll()
        {
            return _db.Set<T>();
        }

        public T FindById(int id)
        { 
            return _db.Set<T>().Find(id);

        }

        public bool Save()
        {
            try
            {
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                _db.Set<T>().Update(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
