using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.Interfaces.IServices;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<Worker> GetWorkerById(int Id)
        {
            return await _SqlsqlunitOfWork.SQLWorkerRepository.GetById(Id);
        }
        public async Task<Worker> AddWorker(Worker worker)
        {
            return await _SqlsqlunitOfWork.SQLWorkerRepository.Add(worker);
        }
        public async Task<Worker> UpdateWorker(Worker worker, object obj)
        {
            return await _SqlsqlunitOfWork.SQLWorkerRepository.Update(worker, obj);
        }
        public async Task<int> DeleteWorker(Worker worker)
        {
            return await  _SqlsqlunitOfWork.SQLWorkerRepository.Delete(worker);
        }

    }
}
