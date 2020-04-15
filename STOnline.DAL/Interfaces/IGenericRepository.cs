using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.DAL.Interfaces.EntityInterfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IQueryable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> Update(TEntity entity, object key);
        Task<int> Delete(TEntity entity);
        Task<int> SaveChangesAsync();
    }
}
