using Newtonsoft.Json;
using STOnline.DAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace STOnline.DAL.Models
{
    public class Repair : BaseEntity
    {
        public string RepairStatus { get; set; }
        public float RepairPrice { get; set; }
        [NotMapped]
        public Order Order { get; set; }
        public int OrderId { get; set; }
        [NotMapped]
        public Worker Worker { get; set; }
        public int WorkerId { get; set; }

    }
}
