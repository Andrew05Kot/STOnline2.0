using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.DAL.Interfaces.Interfaces.IServices
{
    public interface IWorkerCategoryService
    {
        Task<IEnumerable<WorkerCategory>> GetAllWorkerCategoryes();
        Task<WorkerCategory> GetWorkerCategoryById(int Id);
        Task<WorkerCategory> AddWorkerCategory(WorkerCategory workerCategory);
        Task<WorkerCategory> UpdateWorkerCategory(WorkerCategory workerCategory, object obj);
        Task<int> DeleteWorkerCategory(WorkerCategory workerCategory);
    }
}
