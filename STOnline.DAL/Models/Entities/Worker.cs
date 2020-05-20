using Newtonsoft.Json;
using STOnline.DAL.Interfaces.EntityInterfaces;
using STOnline.DAL.Models.Entities;
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
        public ICollection<WorkerCategory> WorkerCategoryes { get; set; }
        public ICollection<Repair> Repairs { get; set; }
  


    }
}
