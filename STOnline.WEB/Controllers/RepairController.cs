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
        public IEnumerable<Repair> Get()
        {
            return _sqlRepairService.GetAllRepairs();
        }
        [Route("Repair/{Id}")]
        [HttpGet]
        public Repair Get(int Id)
        {
            return _sqlRepairService.GetRepairById(Id);
        }
        [Route("Repairs/repair")]
        [HttpPost]
        public void Post([FromBody]Repair repair)
        {
            _sqlRepairService.AddRepair(repair);
        }
        [Route("Repair/repair")]
        [HttpPut]
        public void Put([FromBody]Repair repair)
        {
            _sqlRepairService.UpdateRepair(repair);
        }
        [Route("Repair/delete/{Id}")]
        [HttpDelete]
        public void Delete(Repair repair)
        {
            _sqlRepairService.DeleteRepair(repair);

        }
    }
}