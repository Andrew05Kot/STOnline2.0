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
        [Required]
        [JsonIgnore]
        [ForeignKey("OrderId")]
        public List<Order> Orders { get; set; }
        [JsonIgnore]
        public Guid OrderId { get; set; }
        [Required]
        [JsonIgnore]
        [ForeignKey("WorkerId")]
        public List<Order> Workers { get; set; }
        [JsonIgnore]
        public Guid WorkerId { get; set; }

        //public Repair(int id, string repairStatus, float repairPrice, int orderId, int workerId)
        //{
        //    this.Id = id;
        //    this.RepairStatus = repairStatus;
        //    this.RepairPrice = repairPrice;
        //    this.OrderId = orderId;
        //    this.WorkerId = workerId;
        //}
        //public Repair(string repairStatus, float repairPrice, int orderId, int workerId)
        //{
        //    this.RepairStatus = repairStatus;
        //    this.RepairPrice = repairPrice;
        //    this.OrderId = orderId;
        //    this.WorkerId = workerId;
        //}
        //public Repair() { }
        //public override string ToString()
        //{
        //    return "RepairId: " + this.Id +
        //        "\n" + "\t" + "RepairStatus: " + this.RepairStatus +
        //        "\n" + "\t" + "RepairPrice: " + this.RepairPrice +
        //        "\n" + "\t" + "OrderId: " + this.OrderId +
        //        "\n" + "\t" + "WorkerId: " + this.WorkerId;
        //}
    }
}
