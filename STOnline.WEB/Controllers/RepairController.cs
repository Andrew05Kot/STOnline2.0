using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using STOnline.BLL.Interfaces.IServices;
using STOnline.DAL.Models;

namespace STOnline.WEB.Controllers
{
    public class RepairController : ControllerBase
    {
        IRepairService _repairService;
        public RepairController(IRepairService repairService)
        {
            _repairService = repairService;
        }
        [Route("Repairs")]
        [HttpGet]
        public async Task<IEnumerable<Repair>> Get()
        {
            return await _repairService.GetAllRepairs();
        }
        [Route("Repair/{Id}")]
        [HttpGet]
        public async Task<Repair> Get(int Id)
        {
            return await _repairService.GetRepairById(Id);
        }
        [Route("Repairs/repair")]
        [HttpPost]
        public async Task<Repair> Post([FromBody]Repair repair)
        {
            return await _repairService.AddRepair(repair);
        }
        [Route("Repair/repair")]
        [HttpPut]
        public async Task<Repair> Put([FromBody]Repair repair, object obj)
        {
            return await _repairService.UpdateRepair(repair, obj);
        }
        [Route("Repair/delete/{Id}")]
        [HttpDelete]
        public async Task<int> Delete(Repair repair)
        {
            return await _repairService.DeleteRepair(repair);

        }
    }
}