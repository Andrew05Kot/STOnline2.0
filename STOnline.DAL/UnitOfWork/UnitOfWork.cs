using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.Interfaces;
using STOnline.DAL.Interfaces.Interfaces.IRepositories;
using STOnline.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ICategoryRepository _sqlCategoryRepository;
        private readonly IClientRepository _sqlClientRepository;
        private readonly IOrderRepository _sqlOrderRepository;
        private readonly IRepairRepository _sqlRepairRepository;
        private readonly IWorkerRepository _sqlWorkerRepository;
        private readonly IWorkerCategoryRepository _sqlWorkerCategoryRepository;
        
        public UnitOfWork(ICategoryRepository sqlCategoryRepository,
            IClientRepository sqlClientRepository,
            IOrderRepository sqlOrderRepository,
            IRepairRepository sqlRepairRepository,
            IWorkerRepository sqlWorkerRepository,
            IWorkerCategoryRepository sqlWorkerCategoryRepository
            )
        {
            _sqlCategoryRepository = sqlCategoryRepository;
            _sqlClientRepository = sqlClientRepository;
            _sqlOrderRepository = sqlOrderRepository;
            _sqlRepairRepository = sqlRepairRepository;
            _sqlWorkerRepository = sqlWorkerRepository;
            _sqlWorkerCategoryRepository = sqlWorkerCategoryRepository;
        }
        public ICategoryRepository SQLCategoryRepository
        {
            get
            {
                return _sqlCategoryRepository;
            }
        }
        public IClientRepository SQLClientRepository
        {
            get
            {
                return _sqlClientRepository;
            }
        }
        public IOrderRepository SQLOrderRepository
        {
            get
            {
                return _sqlOrderRepository;
            }
        }
        public IRepairRepository SQLRepairRepository
        {
            get
            {
                return _sqlRepairRepository;
            }
        }
        public IWorkerRepository SQLWorkerRepository
        {
            get
            {
                return _sqlWorkerRepository;
            }
        }
        public IWorkerCategoryRepository SQLWorkerCategoryRepository
        {
            get
            {
                return _sqlWorkerCategoryRepository;
            }
        }
        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
}
