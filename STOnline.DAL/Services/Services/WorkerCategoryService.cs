using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.Interfaces.IServices;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.DAL.Services.Services
{
    public class WorkerCategoryService : IWorkerCategoryService
    {
        IUnitOfWork _SqlsqlunitOfWork;
        public WorkerCategoryService(IUnitOfWork sqlsqlunitOfWork)
        {
            _SqlsqlunitOfWork = sqlsqlunitOfWork;
        }

        public async Task<IEnumerable<WorkerCategory>> GetAllWorkerCategoryes()
        {
            return await _SqlsqlunitOfWork.SQLWorkerCategoryRepository.GetAll();
        }

        public async Task<WorkerCategory> GetWorkerCategoryById(int Id)
        {
            return await _SqlsqlunitOfWork.SQLWorkerCategoryRepository.GetById(Id);
        }
        public async Task<WorkerCategory> AddWorkerCategory(WorkerCategory workerCategory)
        {
            return await _SqlsqlunitOfWork.SQLWorkerCategoryRepository.Add(workerCategory);
        }
        public async Task<WorkerCategory> UpdateWorkerCategory(WorkerCategory workerCategory, object obj)
        {
            return await _SqlsqlunitOfWork.SQLWorkerCategoryRepository.Update(workerCategory, obj);
        }
        public async Task<int> DeleteWorkerCategory(WorkerCategory workerCategory)
        {
            return await _SqlsqlunitOfWork.SQLWorkerCategoryRepository.Delete(workerCategory);
        }

    }
}
