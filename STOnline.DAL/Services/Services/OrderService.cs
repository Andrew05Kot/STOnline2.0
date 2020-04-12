using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.EntityInterfaces.SQLInterfaces.ISQLServices;
using STOnline.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.DAL.Services.SQLServices
{
    public class OrderService : IOrderService
    {
        IUnitOfWork _SqlsqlunitOfWork;
        public OrderService(IUnitOfWork sqlsqlunitOfWork)
        {
            _SqlsqlunitOfWork = sqlsqlunitOfWork;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _SqlsqlunitOfWork.SQLOrderRepository.GetAll();
        }

        public async Task<Order> GetOrderById(int Id)
        {
            return await _SqlsqlunitOfWork.SQLOrderRepository.GetById(Id);
        }
        public async Task<Order> AddOrder(Order order)
        {
            return await _SqlsqlunitOfWork.SQLOrderRepository.Add(order);
        }
        public async Task<Order> UpdateOrder(Order order, object obj)
        {
            return await _SqlsqlunitOfWork.SQLOrderRepository.Update(order, obj);
        }
        public async Task<int> DeleteOrder(Order order)
        {
            return await _SqlsqlunitOfWork.SQLOrderRepository.Delete(order);
        }

    }
}
