using Dapper;
using Microsoft.EntityFrameworkCore;
using STOnline.DAL.DBContext;
using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.EntityInterfaces;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.DAL.Repositoryes
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        internal ApplicationContext _context;
        internal DbSet<TEntity> _dbSet;

        public GenericRepository(ApplicationContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public async Task<TEntity> GetById(int id)
        { 
            return await _dbSet.FindAsync(id);
        }
        public void Add(TEntity newEntity)
        {
            _dbSet.Add(newEntity);
            _context.SaveChanges();
        }
        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(TEntity entity)
        {
             _dbSet.Remove(entity);
            _context.SaveChanges();
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
