using STOnline.DAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Models
{
    public class Repair : IEntity<int>
    {
        public int Id { get; set; }
        public string RepairStatus { get; set; }
        public float RepairPrice { get; set; }
        public int OrderId { get; set; }
        public int WorkerId { get; set; }

        public Repair(int id, string repairStatus, float repairPrice, int orderId, int workerId)
        {
            this.Id = id;
            this.RepairStatus = repairStatus;
            this.RepairPrice = repairPrice;
            this.OrderId = orderId;
            this.WorkerId = workerId;
        }
        public Repair(string repairStatus, float repairPrice, int orderId, int workerId)
        {
            this.RepairStatus = repairStatus;
            this.RepairPrice = repairPrice;
            this.OrderId = orderId;
            this.WorkerId = workerId;
        }
        public Repair() { }
        public override string ToString()
        {
            return "RepairId: " + this.Id +
                "\n" + "\t" + "RepairStatus: " + this.RepairStatus +
                "\n" + "\t" + "RepairPrice: " + this.RepairPrice +
                "\n" + "\t" + "OrderId: " + this.OrderId +
                "\n" + "\t" + "WorkerId: " + this.WorkerId;
        }
    }
}
