using STOnline.BLL.Interfaces.IServices;
using STOnline.DAL.Interfaces;
using STOnline.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.BLL.Services.Services
{
    public class OrderService : IOrderService
    {
        IUnitOfWork _unitOfWork;
        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await _unitOfWork.OrderRepository.GetAll();
        }

        public async Task<Order> GetOrderById(int Id)
        {
            return await _unitOfWork.OrderRepository.GetById(Id);
        }
        public async Task<Order> AddOrder(Order order)
        {
            return await _unitOfWork.OrderRepository.Add(order);
        }
        public async Task<Order> UpdateOrder(Order order, object obj)
        {
            return await _unitOfWork.OrderRepository.Update(order, obj);
        }
        public async Task<int> DeleteOrder(Order order)
        {
            return await _unitOfWork.OrderRepository.Delete(order);
        }

    }
}
