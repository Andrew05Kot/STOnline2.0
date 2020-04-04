using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.DAL.Interfaces.EntityInterfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity item);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Delete(TEntity item);
        void Update(TEntity item);

    }
}
