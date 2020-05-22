using STOnline.DAL.Helpers;
using STOnline.DAL.Helpers.QueryParameters;
using STOnline.DAL.Interfaces.EntityInterfaces;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.DAL.Interfaces.Interfaces.IRepositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        PagedList<Category> GetCategories(CategoryQueryParametr categoryQueryParametr);
        Task<IEnumerable<Category>> GetAllDesc();
    }
}
