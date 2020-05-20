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
        public async Task<IQueryable<TEntity>> GetAll()
        {
            List<TEntity> list = await _dbSet.ToListAsync();
            return list.AsQueryable();
        }

        public async Task<TEntity> GetById(int id)
        { 
            return await _dbSet.FindAsync(id);
        }
        public async Task<TEntity> Add(TEntity newEntity)
        {
            _dbSet.Add(newEntity);
            await _context.SaveChangesAsync();
            return newEntity;
        }
        public async Task<TEntity> Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<int> Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
