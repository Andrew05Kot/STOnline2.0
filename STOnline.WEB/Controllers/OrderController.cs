using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using STOnline.BLL.Interfaces.IServices;
using STOnline.BLL.DTOs;
using STOnline.DAL.Models;

namespace STOnline.Controllers
{
    public class OrderController : ControllerBase
    {
        IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [Route("Orders")]
        [HttpGet]
        public async Task<IEnumerable<OrderDTO>> Get()
        {
            return await _orderService.GetAllOrders();
        }
        [Route("Order/{Id}")]
        [HttpGet]
        public async Task<OrderDTO> Get(int Id)
        {
            return await _orderService.GetOrderById(Id);
        }
        [Route("Orders/order")]
        [HttpPost]
        public async Task<Order> Post([FromBody]OrderDTO order)
        {
            return await _orderService.AddOrder(order);
        }
        [Route("Order/order")]
        [HttpPut]
        public async Task<Order> Put([FromBody]OrderDTO order)
        {
            return await _orderService.UpdateOrder(order);
        }
        [Route("Order/delete/{Id}")]
        [HttpDelete]
        public async Task<int> Delete(OrderDTO order)
        {
            return await _orderService.DeleteOrder(order);

        }

    }
}
