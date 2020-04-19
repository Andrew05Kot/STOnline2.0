using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.BLL.DTOs
{
    public class RepairDTO
    {
        public int Id { get; set; }
        public string RepairStatus { get; set; }
        public float RepairPrice { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public Worker Worker { get; set; }
        public int WorkerId { get; set; }
    }
}
