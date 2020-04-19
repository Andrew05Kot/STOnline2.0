using STOnline.BLL.DTOs;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.BLL.Interfaces.IServices
{
    public interface IWorkerService
    {
        Task<IEnumerable<WorkerDTO>> GetAllWorkers();
        Task<WorkerDTO> GetWorkerById(int Id);
        Task<Worker> AddWorker(WorkerDTO worker);
        Task<Worker> UpdateWorker(WorkerDTO worker);
        Task<int> DeleteWorker(WorkerDTO worker);
    }
}
