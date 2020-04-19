using STOnline.DAL.Interfaces;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using STOnline.BLL.Interfaces.IServices;

namespace STOnline.BLL.Services.Services
{
    public class WorkerService : IWorkerService
    {
        IUnitOfWork _unitOfWork;
        public WorkerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Worker>> GetAllWorkers()
        {
            return await _unitOfWork.WorkerRepository.GetAll();
        }

        public async Task<Worker> GetWorkerById(int Id)
        {
            return await _unitOfWork.WorkerRepository.GetById(Id);
        }
        public async Task<Worker> AddWorker(Worker worker)
        {
            return await _unitOfWork.WorkerRepository.Add(worker);
        }
        public async Task<Worker> UpdateWorker(Worker worker, object obj)
        {
            return await _unitOfWork.WorkerRepository.Update(worker, obj);
        }
        public async Task<int> DeleteWorker(Worker worker)
        {
            return await  _unitOfWork.WorkerRepository.Delete(worker);
        }

    }
}
