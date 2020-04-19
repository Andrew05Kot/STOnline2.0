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
        public WorkerCategoryService(IUnitOfWork unitOfWork)
        {
            _sqlunitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<WorkerCategory>> GetAllWorkerCategoryes()
        {
            return await _sqlunitOfWork.WorkerCategoryRepository.GetAll();
        }

        public async Task<WorkerCategory> GetWorkerCategoryById(int Id)
        {
            return await _sqlunitOfWork.WorkerCategoryRepository.GetById(Id);
        }
        public async Task<WorkerCategory> AddWorkerCategory(WorkerCategory workerCategory)
        {
            return await _sqlunitOfWork.WorkerCategoryRepository.Add(workerCategory);
        }
        public async Task<WorkerCategory> UpdateWorkerCategory(WorkerCategory workerCategory, object obj)
        {
            return await _sqlunitOfWork.WorkerCategoryRepository.Update(workerCategory, obj);
        }
        public async Task<int> DeleteWorkerCategory(WorkerCategory workerCategory)
        {
            return await _sqlunitOfWork.WorkerCategoryRepository.Delete(workerCategory);
        }

    }
}
