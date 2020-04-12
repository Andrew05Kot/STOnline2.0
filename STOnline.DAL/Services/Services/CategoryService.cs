using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.Interfaces.IServices;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.DAL.Services.Services
{
    public class CategoryService : ICategoryService
    {
        IUnitOfWork _SqlsqlunitOfWork;
        public CategoryService(IUnitOfWork sqlsqlunitOfWork)
        {
            _SqlsqlunitOfWork = sqlsqlunitOfWork;
        }

        public IEnumerable<Category> GetAllCategoryes()
        {
            return _SqlsqlunitOfWork.SQLCategoryRepository.GetAll();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _SqlsqlunitOfWork.SQLCategoryRepository.GetById(id);
        }
        public async Task<Category> AddCategory(Category category)
        {
            return await _SqlsqlunitOfWork.SQLCategoryRepository.Add(category);
        }
        public async Task<int> DeleteCategory(Category category)
        {
            return await _SqlsqlunitOfWork.SQLCategoryRepository.Delete(category);
        }

        public async Task<Category> UpdateCategory(Category category, object key)
        {
            return await _SqlsqlunitOfWork.SQLCategoryRepository.Update(category, key);
        }
    }
}
