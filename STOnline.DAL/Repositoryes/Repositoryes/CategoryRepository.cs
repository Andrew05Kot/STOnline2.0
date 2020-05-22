using STOnline.DAL.DBContext;
using STOnline.DAL.Helpers.QueryParameters;
using STOnline.DAL.Interfaces.Interfaces.IRepositories;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace STOnline.DAL.Repositoryes.Repositoryes
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

        //public IEnumerable<Category> GetAllCategories(CategoryQueryParametr categoryQueryParametr)
        //{
        //    return GetAll().Skip((categoryQueryParametr.PageNumber - 1) * categoryQueryParametr.PageSize)
        //        .Take(categoryQueryParametr.PageSize)
        //        .ToList();
        //}
    }
}
