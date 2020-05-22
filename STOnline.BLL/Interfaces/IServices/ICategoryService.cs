using STOnline.BLL.DTOs;
using STOnline.DAL.Helpers;
using STOnline.DAL.Helpers.QueryParameters;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.BLL.Interfaces.IServices
{
    public interface ICategoryService
    {
        PagedList<Category> GetCategories(CategoryQueryParametr categoryQueryParametr);
        Task<IEnumerable<CategoryDTO>> GetAllCategoryes();
        //Task<IEnumerable<Category>> GetAllCategoryesDesc();
        Task<CategoryDTO> GetCategoryById(int Id);
        Task<Category> AddCategory(CategoryDTO category);
        Task<Category> UpdateCategory(CategoryDTO category);
        Task<int> DeleteCategory(CategoryDTO category);

        
    }
}
