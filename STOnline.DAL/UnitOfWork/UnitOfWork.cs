using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.Interfaces.IRepositories;
using STOnline.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IOrderRepository _sqlOrderRepository;
        private readonly IClientRepository _sqlClientRepository;
        public UnitOfWork(IOrderRepository sqlOrderRepository, IClientRepository sqlClientRepository)
        {
            _sqlOrderRepository = sqlOrderRepository;
            _sqlClientRepository = sqlClientRepository;
        }

        public IOrderRepository SQLOrderRepository
        {
            get
            {
                return _sqlOrderRepository;
            }
        }
        public IClientRepository SQLClientRepository
        {
            get
            {
                return _sqlClientRepository;
            }
        }

        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
}
