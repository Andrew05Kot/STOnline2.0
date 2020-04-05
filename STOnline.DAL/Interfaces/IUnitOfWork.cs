using System;
using System.Collections.Generic;
using System.Text;
using STOnline.DAL.Interfaces.Interfaces;
using STOnline.DAL.Interfaces.Interfaces.IRepositories;
using STOnline.DAL.Interfaces.SQLInterfaces.ISQLRepositories;

namespace STOnline.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IOrderRepository SQLOrderRepository { get; }
        ICategoryRepository SQLCategoryRepository { get; }
        IClientRepository SQLClientRepository { get; }
        IRepairRepository SQLRepairRepository { get; }
        IWorkerCategoryRepository SQLWorkerCategoryRepository { get; }
        IWorkerRepository SQLWorkerRepository { get; }
        void Complete();
    }
}
