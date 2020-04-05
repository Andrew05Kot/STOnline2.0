using STOnline.DAL.DBContext;
using STOnline.DAL.Interfaces.Interfaces.IRepositories;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Repositoryes.Repositoryes
{
    public class WorkerRepository : GenericRepository<Worker>, IWorkerRepository
    {
        public WorkerRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }
    }
}
