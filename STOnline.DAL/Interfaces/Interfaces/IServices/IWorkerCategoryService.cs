using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Interfaces.Interfaces.IServices
{
    public interface IWorkerCategoryService
    {
        IEnumerable<WorkerCategory> GetAllWorkerCategoryes();
        WorkerCategory GetWorkerCategoryById(int Id);
        void AddWorkerCategory(WorkerCategory workerCategory);
        void UpdateWorkerCategory(WorkerCategory workerCategory);
        void DeleteWorkerCategory(WorkerCategory workerCategory);
    }
}
