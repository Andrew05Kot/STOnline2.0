using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.DAL.Interfaces.Interfaces.IServices
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategoryes();
        Task<Category> GetCategoryById(int Id);
        Task<Category> AddCategory(Category category);
        Task<Category> UpdateCategory(Category category, object key);
        Task<int> DeleteCategory(Category category);
    }
}
