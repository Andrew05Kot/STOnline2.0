using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using STOnline.DAL.Interfaces.Interfaces.IServices;
using STOnline.DAL.Models;

namespace STOnline.WEB.Controllers
{
    public class ClientController : ControllerBase
    {
        IClientService _sqlClientService;
        public ClientController(IClientService sqlClientService)
        {
            _sqlClientService = sqlClientService;
        }
        [Route("Clients")]
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _sqlClientService.GetAllClients();
        }
        [Route("Client/{Id}")]
        [HttpGet]
        public async Task<Client> Get(int Id)
        {
            return await _sqlClientService.GetClientById(Id);
        }
        [Route("Clients/client")]
        [HttpPost]
        public async Task<Client> Post([FromBody]Client client)
        {
            return await _sqlClientService.AddClient(client);
        }
        [Route("Client/client")]
        [HttpPut]
        public async Task<Client> Put([FromBody]Client client, object key)
        {
            return await _sqlClientService.UpdateClient(client, key);
        }
        [Route("Client/delete/{Id}")]
        [HttpDelete]
        public async Task<int> Delete(Client client)
        {
            return await _sqlClientService.DeleteClient(client);

        }
    }
}