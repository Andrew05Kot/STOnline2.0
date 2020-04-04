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
        public Worker Worker { get; set; }
        [Required]
        public Guid WorkerId { get; set; }
        public Category Category { get; set; }
        [Required]
        public Guid CategoryId { get; set; }

    }
}
