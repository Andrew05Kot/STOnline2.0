using AutoMapper;
using STOnline.BLL.DTOs;
using STOnline.BLL.Interfaces;
using STOnline.BLL.Interfaces.IServices;
using STOnline.DAL.Helpers;
using STOnline.DAL.Helpers.QueryParameters;
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
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDTO>> GetAllCategoryes()
        {
            var data = await _unitOfWork.CategoryRepository.GetAll();
            List<CategoryDTO> transferedToDTO = new List<CategoryDTO>();
            foreach (var categories in data)
            {
                transferedToDTO.Add(_mapper.Map<Category, CategoryDTO>(categories));
            }
            return transferedToDTO;
        }
        public PagedList<Category> GetCategories(CategoryQueryParametr categoryQueryParametr)
        {
            return _unitOfWork.CategoryRepository.GetCategories(categoryQueryParametr);
        }
        public async Task<CategoryDTO> GetCategoryById(int id)
        {
            var data = await _unitOfWork.CategoryRepository.GetById(id);
            return _mapper.Map<Category, CategoryDTO>(data);
        }
        public async Task<Category> AddCategory(CategoryDTO category)
        {
            var data = _mapper.Map<CategoryDTO, Category>(category);
            return await _unitOfWork.CategoryRepository.Add(data);
        }
        public async Task<int> DeleteCategory(CategoryDTO category)
        {
            var data = _mapper.Map<CategoryDTO, Category>(category);
            return await _unitOfWork.CategoryRepository.Delete(data);
        }

        public async Task<Category> UpdateCategory(CategoryDTO category)
        {
            var data = _mapper.Map<CategoryDTO, Category>(category);
            return await _unitOfWork.CategoryRepository.Update(data);
        }

    }
}
