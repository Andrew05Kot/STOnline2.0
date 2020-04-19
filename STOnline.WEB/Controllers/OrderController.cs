using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using STOnline.DAL.Model;
using STOnline.BLL.Interfaces.IServices;

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
        public async Task<IEnumerable<Order>> Get()
        {
            return await _orderService.GetAllOrders();
        }
        [Route("Order/{Id}")]
        [HttpGet]
        public async Task<Order> Get(int Id)
        {
            return await _orderService.GetOrderById(Id);
        }
        [Route("Orders/order")]
        [HttpPost]
        public async Task<Order> Post([FromBody]Order order)
        {
            return await _orderService.AddOrder(order);
        }
        [Route("Order/order")]
        [HttpPut]
        public async Task<Order> Put([FromBody]Order order, object obj)
        {
            return await _orderService.UpdateOrder(order, obj);
        }
        [Route("Order/delete/{Id}")]
        [HttpDelete]
        public async Task<int> Delete(Order order)
        {
            return await _orderService.DeleteOrder(order);

        }

    }
}
