using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using STOnline.DAL.Interfaces.Interfaces.IServices;
using STOnline.DAL.Models;

namespace STOnline.WEB.Controllers
{
    public class CategoryController : ControllerBase
    {
        ICategoryService _sqlCategoryService;
        public CategoryController(ICategoryService sqlCategoryService)
        {
            _sqlCategoryService = sqlCategoryService;
        }
        [Route("Categoryes")]
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _sqlCategoryService.GetAllCategoryes();
        }
        [Route("Category/{Id}")]
        [HttpGet]
        public async Task<Category> Get(int Id)
        {
            return await _sqlCategoryService.GetCategoryById(Id);
        }
        [Route("Categoryes/category")]
        [HttpPost]
        public async Task<Category> Post([FromBody]Category category)
        {
            return await _sqlCategoryService.AddCategory(category);
        }
        [Route("Category/category")]
        [HttpPut]
        public async Task<Category> Put([FromBody]Category category, object obj)
        {
            return await _sqlCategoryService.UpdateCategory(category, obj);
        }
        [Route("Category/delete/{Id}")]
        [HttpDelete]
        public async Task<int> Delete(Category category)
        {
            return await _sqlCategoryService.DeleteCategory(category);

        }
    }
}