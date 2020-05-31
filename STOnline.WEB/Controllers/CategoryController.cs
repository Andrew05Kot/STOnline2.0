using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;
using FluentValidation.Validators;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using STOnline.BLL.DTOs;
using STOnline.BLL.Interfaces.IServices;
using STOnline.BLL.Validation;
using STOnline.DAL.Helpers.QueryParameters;
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
        public async Task<IEnumerable<CategoryDTO>> Get()
        {
            return await _categoryService.GetAllCategoryes();
        }
        [Route("CategoryesP")]
        [HttpGet]
        public IActionResult GetAll([FromQuery]CategoryQueryParametr categoryQueryParametr)
        {
            var categories = _categoryService.GetCategories(categoryQueryParametr).ToList();
            if(categories != null)
            {
                return Ok(categories);
            } else
            {
                return NotFound("Categories list is empty or query parametr is incorrect");
            }
            
        }
        [Route("Category/{Id}")]
        [HttpGet]
        public async Task<CategoryDTO> Get(int Id)
        {
            return await _categoryService.GetCategoryById(Id);
        }
        [Route("Categoryes/category")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CategoryDTO category)
        {
            CategoryDTOValidator validator = new CategoryDTOValidator();
            ValidationResult results = validator.Validate(category);
            if (results.IsValid)
            {
                return Ok( await _categoryService.AddCategory(category) );
            } 
            else
            {
                foreach(ValidationFailure failure in results.Errors)
                {
                    BindingList<string> errors = new BindingList<string>();
                    errors.Add("Category is not valid: " + failure.ErrorMessage);
                    return ValidationProblem("Category is not valid: " + failure.ErrorMessage);
                }
                return StatusCode(422);
            }
            
        }
        [Route("Category/category")]
        [HttpPut]
        public async Task<Category> Put([FromBody]CategoryDTO category)
        {
            return await _categoryService.UpdateCategory(category);
        }
        [Route("Category/delete/{Id}")]
        [HttpDelete]
        public async Task<int> Delete(CategoryDTO category)
        {
            return await _categoryService.DeleteCategory(category);

        }
    }
}