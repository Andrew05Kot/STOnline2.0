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
    public class WorkerCategoryController : ControllerBase
    {
        IWorkerCategoryService _workerCategoryService;
        public WorkerCategoryController(IWorkerCategoryService workerCategoryService)
        {
            _workerCategoryService = workerCategoryService;
        }
        [Route("WorkerCategoryes")]
        [HttpGet]
        public async Task<IEnumerable<WorkerCategoryDTO>> Get()
        {
            return await _workerCategoryService.GetAllWorkerCategoryes();
        }
        [Route("WorkerCategory/{Id}")]
        [HttpGet]
        public async Task<WorkerCategoryDTO> Get(int Id)
        {
            return await _workerCategoryService.GetWorkerCategoryById(Id);
        }
        [Route("WorkerCategoryes/workerCategory")]
        [HttpPost]
        public async Task<WorkerCategory> Post([FromBody]WorkerCategoryDTO workerCategory)
        {
            return await _workerCategoryService.AddWorkerCategory(workerCategory);
        }
        [Route("WorkeCategoryr/workerCategory")]
        [HttpPut]
        public async Task<WorkerCategory> Put([FromBody]WorkerCategoryDTO workerCategory)
        {
            return await _workerCategoryService.UpdateWorkerCategory(workerCategory);
        }
        [Route("WorkerCategory/delete/{Id}")]
        [HttpDelete]
        public async Task<int> Delete(WorkerCategoryDTO workerCategory)
        {
           return await _workerCategoryService.DeleteWorkerCategory(workerCategory);

        }
    }
}