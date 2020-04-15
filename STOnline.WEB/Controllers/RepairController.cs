using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using STOnline.DAL.Interfaces.Interfaces.IServices;
using STOnline.DAL.Models;

namespace STOnline.WEB.Controllers
{
    public class RepairController : ControllerBase
    {
        IRepairService _sqlRepairService;
        public RepairController(IRepairService sqlRepairService)
        {
            _sqlRepairService = sqlRepairService;
        }
        [Route("Repairs")]
        [HttpGet]
        public async Task<IEnumerable<Repair>> Get()
        {
            return await _sqlRepairService.GetAllRepairs();
        }
        [Route("Repair/{Id}")]
        [HttpGet]
        public async Task<Repair> Get(int Id)
        {
            return await _sqlRepairService.GetRepairById(Id);
        }
        [Route("Repairs/repair")]
        [HttpPost]
        public async Task<Repair> Post([FromBody]Repair repair)
        {
            return await _sqlRepairService.AddRepair(repair);
        }
        [Route("Repair/repair")]
        [HttpPut]
        public async Task<Repair> Put([FromBody]Repair repair, object obj)
        {
            return await _sqlRepairService.UpdateRepair(repair, obj);
        }
        [Route("Repair/delete/{Id}")]
        [HttpDelete]
        public async Task<int> Delete(Repair repair)
        {
            return await _sqlRepairService.DeleteRepair(repair);

        }
    }
}