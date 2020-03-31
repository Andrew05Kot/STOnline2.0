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
        public IEnumerable<Order> Get()
        {
            return _sqlOrderService.GetAllOrders();
        }
        [Route("Order/{Id}")]
        [HttpGet]
        public Order Get(int Id)
        {
            return _sqlOrderService.GetOrderById(Id);
        }
        [Route("Orders/order")]
        [HttpPost]
        public void Post([FromBody]Order order)
        {
            _sqlOrderService.AddOrder(order);
        }
        [Route("Order/order")]
        [HttpPut]
        public void Put([FromBody]Order order)
        {
            _sqlOrderService.UpdateOrder(order);
        }
        [Route("Order/delete/{Id}")]
        [HttpDelete]
        public void Delete(Order order)
        {
            _sqlOrderService.DeleteOrder(order);

        }

    }
}
