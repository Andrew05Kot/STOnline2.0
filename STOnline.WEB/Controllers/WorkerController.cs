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
        public async Task<IEnumerable<Worker>> Get()
        {
            return await _sqlWorkerService.GetAllWorkers();
        }
        [Route("Worker/{Id}")]
        [HttpGet]
        public async Task<Worker> Get(int Id)
        {
            return await _sqlWorkerService.GetWorkerById(Id);
        }
        [Route("Workers/worker")]
        [HttpPost]
        public async Task<Worker> Post([FromBody]Worker worker)
        {
            return await _sqlWorkerService.AddWorker(worker);
        }
        [Route("Worker/worker")]
        [HttpPut]
        public async Task<Worker> Put([FromBody]Worker worker, object obj)
        {
            return await  _sqlWorkerService.UpdateWorker(worker, obj);
        }
        [Route("Worker/delete/{Id}")]
        [HttpDelete]
        public async Task<int> Delete(Worker worker)
        {
            return await _sqlWorkerService.DeleteWorker(worker);

        }
    }
}