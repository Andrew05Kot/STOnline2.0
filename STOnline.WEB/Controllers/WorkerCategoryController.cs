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
        public WorkerCategory Get(int Id)
        {
            return _sqlWorkerCategoryService.GetWorkerCategoryById(Id);
        }
        [Route("WorkerCategoryes/workerCategory")]
        [HttpPost]
        public void Post([FromBody]WorkerCategory workerCategory)
        {
            _sqlWorkerCategoryService.AddWorkerCategory(workerCategory);
        }
        [Route("WorkeCategoryr/workerCategory")]
        [HttpPut]
        public void Put([FromBody]WorkerCategory workerCategory)
        {
            _sqlWorkerCategoryService.UpdateWorkerCategory(workerCategory);
        }
        [Route("WorkerCategory/delete/{Id}")]
        [HttpDelete]
        public void Delete(WorkerCategory workerCategory)
        {
            _sqlWorkerCategoryService.DeleteWorkerCategory(workerCategory);

        }
    }
}