using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IOrderRepository _sqlOrderRepository;
        public UnitOfWork(IOrderRepository sqlOrderRepository)
        {
            _sqlOrderRepository = sqlOrderRepository;
        }

        public IOrderRepository SQLOrderRepository
        {
            get
            {
                return _sqlOrderRepository;
            }
        }

        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
}
