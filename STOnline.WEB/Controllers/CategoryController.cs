using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using STOnline.BLL.Interfaces.IServices;
using STOnline.DAL.Models;

namespace STOnline.WEB.Controllers
{
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [Route("Categoryes")]
        [HttpGet]
        public async Task<IEnumerable<Category>> Get()
        {
            return await _categoryService.GetAllCategoryes();
        }
        [Route("Category/{Id}")]
        [HttpGet]
        public async Task<Category> Get(int Id)
        {
            return await _categoryService.GetCategoryById(Id);
        }
        [Route("Categoryes/category")]
        [HttpPost]
        public async Task<Category> Post([FromBody]Category category)
        {
            return await _categoryService.AddCategory(category);
        }
        [Route("Category/category")]
        [HttpPut]
        public async Task<Category> Put([FromBody]Category category, object obj)
        {
            return await _categoryService.UpdateCategory(category, obj);
        }
        [Route("Category/delete/{Id}")]
        [HttpDelete]
        public async Task<int> Delete(Category category)
        {
            return await _categoryService.DeleteCategory(category);

        }
    }
}