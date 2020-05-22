using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.Interfaces;
using STOnline.DAL.Interfaces.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IWorkerRepository _workerRepository;
        private readonly IWorkerCategoryRepository _workerCategoryRepository;
        
        public UnitOfWork(ICategoryRepository categoryRepository,
            IClientRepository clientRepository,
            IOrderRepository orderRepository,
            IWorkerRepository workerRepository,
            IWorkerCategoryRepository workerCategoryRepository
            )
        {
            _categoryRepository = categoryRepository;
            _clientRepository = clientRepository;
            _orderRepository = orderRepository;
            _workerRepository = workerRepository;
            _workerCategoryRepository = workerCategoryRepository;
        }
        public ICategoryRepository CategoryRepository
        {
            get
            {
                return _categoryRepository;
            }
        }
        public IClientRepository ClientRepository
        {
            get
            {
                return _clientRepository;
            }
        }
        public IOrderRepository OrderRepository
        {
            get
            {
                return _orderRepository;
            }
        }
        public IWorkerRepository WorkerRepository
        {
            get
            {
                return _workerRepository;
            }
        }
        public IWorkerCategoryRepository WorkerCategoryRepository
        {
            get
            {
                return _workerCategoryRepository;
            }
        }
        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
}
