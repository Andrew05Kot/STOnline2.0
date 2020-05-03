using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.BLL.DTOs
{
    public class WorkerDTO
    {
        public int Id { get; set; }
        //public string WorkeLastName { get; set; }
        //public string WorkerFirstName { get; set; }
        //public string WorkerPhoneNumber { get; set; }
        //public string WorkerEmail { get; set; }
        //public string WorkerPassword { get; set; }
        //public ICollection<WorkerCategory> WorkerCategories { get; set; }
        //public ICollection<Repair> Repairs { get; set; }
        public string WorkeLastName { get; set; }
        public string WorkerFirstName { get; set; }
        public string WorkerPhoneNumber { get; set; }
        public string WorkerEmail { get; set; }
        public string WorkerPassword { get; set; }
        //[ForeignKey("WorkerId")]
        //[NotMapped]
        ICollection<WorkerCategory> WorkerCategories { get; set; }
        //[ForeignKey("WorkerId")]
        //[NotMapped]
        public ICollection<Repair> Repairs { get; set; }
    }
}
