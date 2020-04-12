using STOnline.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.DAL.Interfaces.EntityInterfaces.SQLInterfaces.ISQLServices
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAllOrders();
        Task<Order> GetOrderById(int Id);
        Task<Order> AddOrder(Order order);
        Task<Order> UpdateOrder(Order order, object obj);
        Task<int> DeleteOrder(Order order);
    }
}
