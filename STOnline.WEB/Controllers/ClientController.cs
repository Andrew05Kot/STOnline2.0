using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PagedList;
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
        public async Task<IEnumerable<ClientDTO>> Get(int? page)
        {
            //int pageSize = 5;
            //int pageNumber = (page ?? 1);
            //var result = await _clientService.GetAllClients();
            //return result.ToPagedList(pageNumber, pageSize);
            return await _clientService.GetAllClients();
        }
        [Route("Client/{Id}")]
        [HttpGet]
        public async Task<ClientDTO> Get(int Id)
        {
            return await _clientService.GetClientById(Id);
        }
        [Route("Clients/client")]
        [HttpPost]
        public async Task<Client> Post([FromBody]ClientDTO client)
        {
            return await _clientService.AddClient(client);
        }
        [Route("Client/client")]
        [HttpPut]
        public async Task<Client> Put([FromBody]ClientDTO client)
        {
            return await _clientService.UpdateClient(client);
        }
        [Route("Client/delete/{Id}")]
        [HttpDelete]
        public async Task<int> Delete(ClientDTO client)
        {
            return await _clientService.DeleteClient(client);

        }
    }
}