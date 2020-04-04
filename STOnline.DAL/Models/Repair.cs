using Newtonsoft.Json;
using STOnline.DAL.Interfaces.EntityInterfaces;
using STOnline.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace STOnline.DAL.Models
{
    public class Repair : BaseEntity
    {
        [Required]
        public string RepairStatus { get; set; }
        [Required]
        public float RepairPrice { get; set; }
        public Order Orders { get; set; }
        [Required]
        public int OrderId { get; set; }
        public Worker Worker { get; set; }
        [Required]
        public int WorkerId { get; set; }

    }
}
