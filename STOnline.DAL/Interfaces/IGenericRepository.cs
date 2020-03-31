using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Interfaces.EntityInterfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity item);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        void Delete(TEntity item);
        void Update(TEntity item);
    }
}
