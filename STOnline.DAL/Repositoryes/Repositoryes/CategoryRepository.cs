using STOnline.DAL.DBContext;
using STOnline.DAL.Helpers.QueryParameters;
using STOnline.DAL.Interfaces.Interfaces.IRepositories;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using STOnline.DAL.Helpers;

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

    }
}
