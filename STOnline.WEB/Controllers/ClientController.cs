using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using PagedList;
using STOnline.BLL.DTOs;
using STOnline.BLL.Interfaces.IServices;
using STOnline.DAL.Models;

namespace STOnline.WEB.Controllers
{
    public class ClientController : ControllerBase
    {
        IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }
        [Route("Clients")]
        [HttpGet]
        public async Task<IActionResult> Get(/*int? page*/)
        {
            //int pageSize = 5;
            //int pageNumber = (page ?? 1);
            //var result = await _clientService.GetAllClients();
            //return result.ToPagedList(pageNumber, pageSize);
            try
            {
                return Ok(await _clientService.GetAllClients());
            }
            catch
            {
                return StatusCode(404);
            }
        }
        [Route("Client/{Id}")]
        [HttpGet]
        public async Task<IActionResult> Get(int Id)
        {
            try
            {
                return Ok(await _clientService.GetClientById(Id));
            }
            catch
            {
                return StatusCode(404);
            }

        }
        [Route("Clients/client")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ClientDTO client)
        {
            try
            {
                await _clientService.AddClient(client);
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(400);
            }
        }
        [Route("Client/client")]
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]ClientDTO client)
        {
            try
            {
                await _clientService.UpdateClient(client);
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(400);
            }
        }
        [Route("Client/delete/{Id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(ClientDTO client)
        {
            try
            {
                await _clientService.DeleteClient(client);
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(400);
            }

        }
    }
}