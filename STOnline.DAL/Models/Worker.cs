using Newtonsoft.Json;
using STOnline.DAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace STOnline.DAL.Models
{
    public class Worker : BaseEntity
    {
        public string WorkeLastName { get; set; }
        public string WorkerFirstName { get; set; }
        public string WorkerPhoneNumber { get; set; }
        public string WorkerEmail { get; set; }
        public string WorkerPassword { get; set; }
        //[ForeignKey("WorkerId")]
        //[NotMapped]
        public ICollection<WorkerCategory> WorkerCategoryes { get; set; }
        //[ForeignKey("WorkerId")]
        //[NotMapped]
        public ICollection<Repair> Repairs { get; set; }
  


    }
}
