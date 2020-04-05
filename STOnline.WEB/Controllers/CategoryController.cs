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
        public Category Get(int Id)
        {
            return _sqlCategoryService.GetCategoryById(Id);
        }
        [Route("Categoryes/category")]
        [HttpPost]
        public void Post([FromBody]Category category)
        {
            _sqlCategoryService.AddCategory(category);
        }
        [Route("Category/category")]
        [HttpPut]
        public void Put([FromBody]Category category)
        {
            _sqlCategoryService.UpdateCategory(category);
        }
        [Route("Category/delete/{Id}")]
        [HttpDelete]
        public void Delete(Category category)
        {
            _sqlCategoryService.DeleteCategory(category);

        }
    }
}