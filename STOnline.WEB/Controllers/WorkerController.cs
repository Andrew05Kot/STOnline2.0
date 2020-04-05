using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using STOnline.DAL.Interfaces.Interfaces.IServices;
using STOnline.DAL.Models;

namespace STOnline.WEB.Controllers
{
    public class WorkerController : ControllerBase
    {
        IWorkerService _sqlWorkerService;
        public WorkerController(IWorkerService sqlWorkerService)
        {
            _sqlWorkerService = sqlWorkerService;
        }
        [Route("Workers")]
        [HttpGet]
        public IEnumerable<Worker> Get()
        {
            return _sqlWorkerService.GetAllWorkers();
        }
        [Route("Worker/{Id}")]
        [HttpGet]
        public Worker Get(int Id)
        {
            return _sqlWorkerService.GetWorkerById(Id);
        }
        [Route("Workers/worker")]
        [HttpPost]
        public void Post([FromBody]Worker worker)
        {
            _sqlWorkerService.AddWorker(worker);
        }
        [Route("Worker/worker")]
        [HttpPut]
        public void Put([FromBody]Worker worker)
        {
            _sqlWorkerService.UpdateWorker(worker);
        }
        [Route("Worker/delete/{Id}")]
        [HttpDelete]
        public void Delete(Worker worker)
        {
            _sqlWorkerService.DeleteWorker(worker);

        }
    }
}