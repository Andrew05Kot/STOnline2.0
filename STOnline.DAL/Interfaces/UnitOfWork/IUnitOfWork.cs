using STOnline.DAL.Interfaces.Interfaces;
using STOnline.DAL.Interfaces.Interfaces.IRepositories;
using STOnline.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Services.UnitOfWork
{
    public interface IUnitOfWork
    {
        IOrderRepository SQLOrderRepository { get; }
        ICategoryRepository SQLCategoryRepository { get; }
        ICategoryRepository SQLClientRepository { get; }
        IRepairRepository SQLRepairRepository { get; }
        IWorkerCategoryRepository SQLWorkerCategoryRepository { get; }
        IWorkerRepository SQLWorkerRepository { get; }
        void Complete();
    }
}
