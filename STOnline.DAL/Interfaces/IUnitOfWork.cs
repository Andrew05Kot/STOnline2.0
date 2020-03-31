using System;
using System.Collections.Generic;
using System.Text;
using STOnline.DAL.Interfaces.SQLInterfaces.ISQLRepositories;

namespace STOnline.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IOrderRepository SQLOrderRepository { get; }
        
        void Complete();
    }
}
