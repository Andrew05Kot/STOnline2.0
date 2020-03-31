using STOnline.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Services.UnitOfWork
{
    public interface IUnitOfWork
    {
        IOrderRepository SQLOrderRepository { get; }
        void Complete();
    }
}
