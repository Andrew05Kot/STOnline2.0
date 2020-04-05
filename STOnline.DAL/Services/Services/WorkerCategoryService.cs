using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.Interfaces.IServices;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Services.Services
{
    public class WorkerCategoryService : IWorkerCategoryService
    {
        IUnitOfWork _SqlsqlunitOfWork;
        public WorkerCategoryService(IUnitOfWork sqlsqlunitOfWork)
        {
            _SqlsqlunitOfWork = sqlsqlunitOfWork;
        }

        public IEnumerable<WorkerCategory> GetAllWorkerCategoryes()
        {
            return _SqlsqlunitOfWork.SQLWorkerCategoryRepository.GetAll();
        }

        public WorkerCategory GetWorkerCategoryById(int Id)
        {
            return new WorkerCategory();
        }
        public void AddWorkerCategory(WorkerCategory workerCategory)
        {
            _SqlsqlunitOfWork.SQLWorkerCategoryRepository.Add(workerCategory);
        }
        public void DeleteWorkerCategory(WorkerCategory workerCategory)
        {
            _SqlsqlunitOfWork.SQLWorkerCategoryRepository.Delete(workerCategory);
        }

        public void UpdateWorkerCategory(WorkerCategory workerCategory)
        {
            _SqlsqlunitOfWork.SQLWorkerCategoryRepository.Update(workerCategory);
        }
    }
}
