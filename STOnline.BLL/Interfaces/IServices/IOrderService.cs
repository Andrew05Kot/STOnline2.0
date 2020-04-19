using STOnline.BLL.DTOs;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.BLL.Interfaces.IServices
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDTO>> GetAllOrders();
        Task<OrderDTO> GetOrderById(int Id);
        Task<Order> AddOrder(OrderDTO order);
        Task<Order> UpdateOrder(OrderDTO order);
        Task<int> DeleteOrder(OrderDTO order);
    }
}
