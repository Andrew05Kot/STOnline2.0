using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.EntityInterfaces.SQLInterfaces.ISQLServices;
using STOnline.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

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

        public Order GetOrderById(int Id)
        {
            //return _SqlsqlunitOfWork.SQLOrderRepository.GetById(Id);
            return new Order();
        }
        public void AddOrder(Order order)
        {
            _SqlsqlunitOfWork.SQLOrderRepository.Add(order);
        }
        public void DeleteOrder(Order order)
        {
            _SqlsqlunitOfWork.SQLOrderRepository.Delete(order);
        }

        public void UpdateOrder(Order order)
        {
            _SqlsqlunitOfWork.SQLOrderRepository.Update(order);
        }
    }
}
