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
using STOnline.DAL.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace STOnline.Controllers
{
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private UserManager<User> _userManager;

        public OrderController(IOrderService orderService, UserManager<User> userManager)
        {
            _userManager = userManager;
            _orderService = orderService;
        }
        [Route("Orders")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok( await _orderService.GetAllOrders() );
            }
            catch 
            {
                return StatusCode(404);
            }
            
        }
        [Route("Order/{Id}")]
        [HttpGet]
        public async Task<IActionResult> Get(int Id)
        {
            try
            {
                return Ok(await _orderService.GetOrderById(Id));
            }
            catch
            {
                return StatusCode(404);
            }
            
        }
        [Route("Orders/order")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]OrderDTO order)
        {
            try
            {
                await _orderService.AddOrder(order);
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(400);
            }
        }

        [Route("Order/order/upload/{Id}")]
        [HttpPost]
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
        public async Task<IActionResult> Put([FromBody]OrderDTO order)
        {
            try
            {
                await _orderService.UpdateOrder(order);
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(400);
            }
            
        }
        [Route("Order/delete/{Id}")]
        [HttpDelete]
        public async Task<int> Delete(OrderDTO order)
        {
            return await _orderService.DeleteOrder(order);

        }

    }
}
