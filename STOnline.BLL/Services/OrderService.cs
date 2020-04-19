using AutoMapper;
using STOnline.BLL.DTOs;
using STOnline.BLL.Interfaces.IServices;
using STOnline.DAL.Interfaces;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.BLL.Services.Services
{
    public class OrderService : IOrderService
    {
        IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OrderDTO>> GetAllOrders()
        {
            var data = await _unitOfWork.OrderRepository.GetAll();
            List<OrderDTO> transferedToDTO = new List<OrderDTO>();
            foreach (var orders in data)
            {
                transferedToDTO.Add(_mapper.Map<Order, OrderDTO>(orders));
            }
            return transferedToDTO;
        }

        public async Task<OrderDTO> GetOrderById(int Id)
        {
            var data = await _unitOfWork.OrderRepository.GetById(Id);
            return _mapper.Map<Order, OrderDTO>(data);
        }
        public async Task<Order> AddOrder(OrderDTO order)
        {
            var data = _mapper.Map<OrderDTO, Order>(order);
            return await _unitOfWork.OrderRepository.Add(data);
        }
        public async Task<Order> UpdateOrder(OrderDTO order)
        {
            var data = _mapper.Map<OrderDTO, Order>(order);
            return await _unitOfWork.OrderRepository.Update(data);
        }
        public async Task<int> DeleteOrder(OrderDTO order)
        {
            var data = _mapper.Map<OrderDTO, Order>(order);
            return await _unitOfWork.OrderRepository.Delete(data);
        }

    }
}
