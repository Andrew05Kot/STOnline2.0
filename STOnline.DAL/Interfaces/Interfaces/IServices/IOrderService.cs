using STOnline.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Interfaces.EntityInterfaces.SQLInterfaces.ISQLServices
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int Id);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
    }
}
