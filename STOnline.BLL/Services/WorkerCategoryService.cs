using AutoMapper;
using STOnline.BLL.DTOs;
using STOnline.BLL.Interfaces.IServices;
using STOnline.DAL.Interfaces;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.BLL.Services.Services
{
    public class WorkerCategoryService : IWorkerCategoryService
    {
        IUnitOfWork _sqlunitOfWork;
        private readonly IMapper _mapper;

        public WorkerCategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _sqlunitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<WorkerCategoryDTO>> GetAllWorkerCategoryes()
        {
            var data = await _sqlunitOfWork.WorkerCategoryRepository.GetAll();
            List<WorkerCategoryDTO> transferedToDTO = new List<WorkerCategoryDTO>();
            foreach (var workerCategoryes in data)
            {
                transferedToDTO.Add(_mapper.Map<WorkerCategory, WorkerCategoryDTO>(workerCategoryes));
            }
            return transferedToDTO;
        }

        public async Task<WorkerCategoryDTO> GetWorkerCategoryById(int Id)
        {
            var data = await _sqlunitOfWork.WorkerCategoryRepository.GetById(Id);
            return _mapper.Map<WorkerCategory, WorkerCategoryDTO>(data);
        }
        public async Task<WorkerCategory> AddWorkerCategory(WorkerCategoryDTO workerCategory)
        {
            var data = _mapper.Map<WorkerCategoryDTO, WorkerCategory>(workerCategory);
            return await _sqlunitOfWork.WorkerCategoryRepository.Add(data);
        }
        public async Task<WorkerCategory> UpdateWorkerCategory(WorkerCategoryDTO workerCategory)
        {
            var data = _mapper.Map<WorkerCategoryDTO, WorkerCategory>(workerCategory);
            return await _sqlunitOfWork.WorkerCategoryRepository.Update(data);
        }
        public async Task<int> DeleteWorkerCategory(WorkerCategoryDTO workerCategory)
        {
            var data = _mapper.Map<WorkerCategoryDTO, WorkerCategory>(workerCategory);
            return await _sqlunitOfWork.WorkerCategoryRepository.Delete(data);
        }

    }
}
