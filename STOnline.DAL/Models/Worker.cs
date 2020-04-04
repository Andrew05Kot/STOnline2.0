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
        [Required]
        public string WorkeLastName { get; set; }
        [Required]
        public string WorkerFirstName { get; set; }
        [Required]
        public string WorkerPhoneNumber { get; set; }
        [Required]
        public string WorkerEmail { get; set; }
        [Required]
        public string WorkerPassword { get; set; }
        [ForeignKey("WorkerId")]
        public ICollection<WorkerCategory> WorkerCategories { get; set; }
        [ForeignKey("WorkerId")]
        public ICollection<Repair> Repairs { get; set; }


    }
}
