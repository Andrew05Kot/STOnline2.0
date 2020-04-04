using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using STOnline.DAL.Interfaces.Interfaces.IServices;
using STOnline.DAL.Models;

namespace STOnline.WEB.Controllers
{
    public class OrderController : ControllerBase
    {
        IClientService _sqlClientService;
        public OrderController(IClientService sqlClientService)
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
        public Client Get(int Id)
        {
            return _sqlClientService.GetClientById(Id);
        }
        [Route("Clients/client")]
        [HttpPost]
        public void Post([FromBody]Client client)
        {
            _sqlClientService.AddClient(client);
        }
        [Route("Client/client")]
        [HttpPut]
        public void Put([FromBody]Client client)
        {
            _sqlClientService.UpdateClient(client);
        }
        [Route("Client/delete/{Id}")]
        [HttpDelete]
        public void Delete(Client client)
        {
            _sqlClientService.DeleteClient(client);

        }

    }
}