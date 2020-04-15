using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using STOnline.DAL.Services.SQLServices;
using STOnline.DAL.Interfaces;
using STOnline.DAL.Models;
using STOnline.DAL.Repositoryes;
using STOnline.DAL.Interfaces.EntityInterfaces.SQLInterfaces.ISQLServices;
using STOnline.DAL.Model;

namespace STOnline.Controllers
{
    public class OrderController : ControllerBase
    {
        IOrderService _sqlOrderService;
        public OrderController(IOrderService sqlOrderService)
        {
            _sqlOrderService = sqlOrderService;
        }
        [Route("Orders")]
        [HttpGet]
        public async Task<IEnumerable<Order>> Get()
        {
            return await _sqlOrderService.GetAllOrders();
        }
        [Route("Order/{Id}")]
        [HttpGet]
        public async Task<Order> Get(int Id)
        {
            return await _sqlOrderService.GetOrderById(Id);
        }
        [Route("Orders/order")]
        [HttpPost]
        public async Task<Order> Post([FromBody]Order order)
        {
            return await _sqlOrderService.AddOrder(order);
        }
        [Route("Order/order")]
        [HttpPut]
        public async Task<Order> Put([FromBody]Order order, object obj)
        {
            return await _sqlOrderService.UpdateOrder(order, obj);
        }
        [Route("Order/delete/{Id}")]
        [HttpDelete]
        public async Task<int> Delete(Order order)
        {
            return await _sqlOrderService.DeleteOrder(order);

        }

    }
}
