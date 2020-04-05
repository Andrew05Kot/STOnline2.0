using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.Interfaces.IServices;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

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

        public Category GetCategoryById(int Id)
        {
            return new Category();
        }
        public void AddCategory(Category category)
        {
            _SqlsqlunitOfWork.SQLCategoryRepository.Add(category);
        }
        public void DeleteCategory(Category category)
        {
            _SqlsqlunitOfWork.SQLCategoryRepository.Delete(category);
        }

        public void UpdateCategory(Category category)
        {
            _SqlsqlunitOfWork.SQLCategoryRepository.Update(category);
        }
    }
}
