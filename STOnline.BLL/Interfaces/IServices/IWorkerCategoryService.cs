using STOnline.BLL.DTOs;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.BLL.Interfaces.IServices
{
    public interface IWorkerCategoryService
    {
        Task<IEnumerable<WorkerCategoryDTO>> GetAllWorkerCategoryes();
        Task<WorkerCategoryDTO> GetWorkerCategoryById(int Id);
        Task<WorkerCategory> AddWorkerCategory(WorkerCategoryDTO workerCategory);
        Task<WorkerCategory> UpdateWorkerCategory(WorkerCategoryDTO workerCategory);
        Task<int> DeleteWorkerCategory(WorkerCategoryDTO workerCategory);
    }
}
