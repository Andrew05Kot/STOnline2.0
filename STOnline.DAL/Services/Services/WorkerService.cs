using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.Interfaces.IServices;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Services.Services
{
    public class WorkerService : IWorkerService
    {
        IUnitOfWork _SqlsqlunitOfWork;
        public WorkerService(IUnitOfWork sqlsqlunitOfWork)
        {
            _SqlsqlunitOfWork = sqlsqlunitOfWork;
        }

        public IEnumerable<Worker> GetAllWorkers()
        {
            return _SqlsqlunitOfWork.SQLWorkerRepository.GetAll();
        }

        public Worker GetWorkerById(int Id)
        {
            return new Worker();
        }
        public void AddWorker(Worker worker)
        {
            _SqlsqlunitOfWork.SQLWorkerRepository.Add(worker);
        }
        public void DeleteWorker(Worker worker)
        {
            _SqlsqlunitOfWork.SQLWorkerRepository.Delete(worker);
        }

        public void UpdateWorker(Worker worker)
        {
            _SqlsqlunitOfWork.SQLWorkerRepository.Update(worker);
        }
    }
}
