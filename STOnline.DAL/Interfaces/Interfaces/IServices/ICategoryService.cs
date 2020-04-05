using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Interfaces.Interfaces.IServices
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategoryes();
        Category GetCategoryById(int Id);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
    }
}
