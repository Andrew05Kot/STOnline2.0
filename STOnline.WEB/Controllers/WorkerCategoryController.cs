using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using STOnline.DAL.Interfaces.Interfaces.IServices;
using STOnline.DAL.Models;

namespace STOnline.WEB.Controllers
{
    public class WorkerCategoryController : ControllerBase
    {
        IWorkerCategoryService _sqlWorkerCategoryService;
        public WorkerCategoryController(IWorkerCategoryService sqlWorkerCategoryService)
        {
            _sqlWorkerCategoryService = sqlWorkerCategoryService;
        }
        [Route("WorkerCategoryes")]
        [HttpGet]
        public IEnumerable<WorkerCategory> Get()
        {
            return _sqlWorkerCategoryService.GetAllWorkerCategoryes();
        }
        [Route("WorkerCategory/{Id}")]
        [HttpGet]
        public async Task<WorkerCategory> Get(int Id)
        {
            return await _sqlWorkerCategoryService.GetWorkerCategoryById(Id);
        }
        [Route("WorkerCategoryes/workerCategory")]
        [HttpPost]
        public async Task<WorkerCategory> Post([FromBody]WorkerCategory workerCategory)
        {
            return await _sqlWorkerCategoryService.AddWorkerCategory(workerCategory);
        }
        [Route("WorkeCategoryr/workerCategory")]
        [HttpPut]
        public async Task<WorkerCategory> Put([FromBody]WorkerCategory workerCategory, object obj)
        {
            return await _sqlWorkerCategoryService.UpdateWorkerCategory(workerCategory, obj);
        }
        [Route("WorkerCategory/delete/{Id}")]
        [HttpDelete]
        public async Task<int> Delete(WorkerCategory workerCategory)
        {
           return await _sqlWorkerCategoryService.DeleteWorkerCategory(workerCategory);

        }
    }
}