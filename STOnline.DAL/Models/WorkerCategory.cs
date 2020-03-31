using STOnline.DAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Models
{
    public class WorkerCategory : IEntity<int>
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public int CategoryId { get; set; }

        public WorkerCategory(int id, int workerId, int categoryId)
        {
            this.Id = id;
            this.WorkerId = workerId;
            this.CategoryId = categoryId;
        }
        public WorkerCategory(int workerId, int categoryId)
        {
            this.WorkerId = workerId;
            this.CategoryId = categoryId;
        }
        public WorkerCategory() { }
    }
}
