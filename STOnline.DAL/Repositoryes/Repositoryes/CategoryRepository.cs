using STOnline.DAL.DBContext;
using STOnline.DAL.Helpers.QueryParameters;
using STOnline.DAL.Interfaces.Interfaces.IRepositories;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using STOnline.DAL.Helpers;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace STOnline.DAL.Repositoryes.Repositoryes
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

        public PagedList<Category> GetCategories(CategoryQueryParametr categoryQueryParametr)
        {
            return PagedList<Category>.ToPagedList(
                GetAllPaging(),
                categoryQueryParametr.PageNumber,
                categoryQueryParametr.PageSize);
        }
        public async Task<IEnumerable<Category>> GetAllDesc()
        {
            return await _context.Set<Category>().OrderByDescending(c => c.Id).ToListAsync();
        }   


        //public IEnumerable<Category> GetAllCategories(CategoryQueryParametr categoryQueryParametr)
        //{
        //    return GetAll().Skip((categoryQueryParametr.PageNumber - 1) * categoryQueryParametr.PageSize)
        //        .Take(categoryQueryParametr.PageSize)
        //        .ToList();
        //}
    }
}
