using Newtonsoft.Json;
using STOnline.DAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace STOnline.DAL.Models
{
    public class WorkerCategory : BaseEntity
    {
        //public int Id { get; set; }
        [Required]
        [JsonIgnore]
        [ForeignKey("WorkerId")]
        public List<Worker> Workers { get; set; }
        [JsonIgnore]
        public Guid WorkerId { get; set; }
        [Required]
        [JsonIgnore]
        [ForeignKey("CategoryId")]
        public List<Category> Categoryes { get; set; }
        [JsonIgnore]
        public Guid CategoryId { get; set; }

    //    public WorkerCategory(int id, int workerId, int categoryId)
    //    {
    //        this.Id = id;
    //        this.WorkerId = workerId;
    //        this.CategoryId = categoryId;
    //    }
    //    public WorkerCategory(int workerId, int categoryId)
    //    {
    //        this.WorkerId = workerId;
    //        this.CategoryId = categoryId;
    //    }
    //    public WorkerCategory() { }
    }
}
