using System;
using System.Collections.Generic;
using System.Text;
using STOnline.DAL.Interfaces.Interfaces.IRepositories;

namespace STOnline.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IOrderRepository OrderRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IWorkerCategoryRepository WorkerCategoryRepository { get; }
        IWorkerRepository WorkerRepository { get; }
        void Complete();
    }
}
