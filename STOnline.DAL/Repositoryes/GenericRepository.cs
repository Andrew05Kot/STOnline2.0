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
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
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
        public async Task<TEntity> Add(TEntity entity)
        {
            return (await _dbSet.AddAsync(entity)).Entity;
        }
        public Task<TEntity> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
        public Task<TEntity> Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
