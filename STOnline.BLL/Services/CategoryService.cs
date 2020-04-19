using STOnline.BLL.Interfaces;
using STOnline.BLL.Interfaces.IServices;
using STOnline.DAL.Interfaces;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.BLL.Services.Services
{
    public class CategoryService : ICategoryService
    {
        IUnitOfWork _unitOfWork;
        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Category>> GetAllCategoryes()
        {
            return await _unitOfWork.CategoryRepository.GetAll();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _unitOfWork.CategoryRepository.GetById(id);
        }
        public async Task<Category> AddCategory(Category category)
        {
            return await _unitOfWork.CategoryRepository.Add(category);
        }
        public async Task<int> DeleteCategory(Category category)
        {
            return await _unitOfWork.CategoryRepository.Delete(category);
        }

        public async Task<Category> UpdateCategory(Category category, object key)
        {
            return await _unitOfWork.CategoryRepository.Update(category, key);
        }
    }
}
