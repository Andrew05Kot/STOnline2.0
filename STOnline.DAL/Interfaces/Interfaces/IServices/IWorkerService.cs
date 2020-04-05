using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Interfaces.Interfaces.IServices
{
    public interface IWorkerService
    {
        IEnumerable<Worker> GetAllWorkers();
        Worker GetWorkerById(int Id);
        void AddWorker(Worker worker);
        void UpdateWorker(Worker worker);
        void DeleteWorker(Worker worker);
    }
}
