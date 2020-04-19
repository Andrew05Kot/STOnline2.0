using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using STOnline.BLL.DTOs;
using STOnline.BLL.Interfaces.IServices;
using STOnline.DAL.Models;

namespace STOnline.WEB.Controllers
{
    public class WorkerController : ControllerBase
    {
        IWorkerService _workerService;
        public WorkerController(IWorkerService workerService)
        {
            _workerService = workerService;
        }
        [Route("Workers")]
        [HttpGet]
        public async Task<IEnumerable<WorkerDTO>> Get()
        {
            return await _workerService.GetAllWorkers();
        }
        [Route("Worker/{Id}")]
        [HttpGet]
        public async Task<WorkerDTO> Get(int Id)
        {
            return await _workerService.GetWorkerById(Id);
        }
        [Route("Workers/worker")]
        [HttpPost]
        public async Task<Worker> Post([FromBody]WorkerDTO worker)
        {
            return await _workerService.AddWorker(worker);
        }
        [Route("Worker/worker")]
        [HttpPut]
        public async Task<Worker> Put([FromBody]WorkerDTO worker)
        {
            return await  _workerService.UpdateWorker(worker);
        }
        [Route("Worker/delete/{Id}")]
        [HttpDelete]
        public async Task<int> Delete(WorkerDTO worker)
        {
            return await _workerService.DeleteWorker(worker);

        }
    }
}