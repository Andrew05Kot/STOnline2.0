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
        public OrderDTO Order { get; set; }
        public WorkerDTO Worker { get; set; }
    }
}
