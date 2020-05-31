using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using STOnline.BLL.Interfaces.IServices;
using STOnline.BLL.DTOs;
using STOnline.DAL.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace STOnline.Controllers
{
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IWebHostEnvironment _hostEnvironment;
        public OrderController(IOrderService orderService, IWebHostEnvironment hostEnvironment)
        {
            _orderService = orderService;
            _hostEnvironment = hostEnvironment;
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

        [Route("Order/order/upload/{Id}")]
        [HttpPut]
        public async Task Upload(int Id, [FromBody] IFormFile file)
        {
            var fileName = file.FileName;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Images", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            var order = await _orderService.GetOrderById(Id);
            order.ImageUrl = fileName;
            await _orderService.UpdateOrder(order);
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
