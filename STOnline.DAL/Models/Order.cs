using STOnline.DAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STOnline.DAL.Model
{
    public class Order : IEntity<int>
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int CategoryId { get; set; }
        public string ModelAuto { get; set; }
        public string AutoNumber { get; set; }
        public DateTime Data { get; set; }

        public Order(int id, int clientId, int categoryId, string modelAuto, string autoNumber, DateTime data)
        {
            this.Id = id;
            this.ClientId = clientId;
            this.CategoryId = categoryId;
            this.ModelAuto = modelAuto;
            this.AutoNumber = autoNumber;
            this.Data = data;
        }
        public Order(int clientId, int categoryId, string modelAuto, string autoNumber, DateTime data)
        {
            this.ClientId = clientId;
            this.CategoryId = categoryId;
            this.ModelAuto = modelAuto;
            this.AutoNumber = autoNumber;
            this.Data = data;
        }
        public Order() { }
        public override string ToString()
        {
            return "OrderId: " + this.Id +
                "\n" + "\t" + "ClientId: " + this.ClientId +
                "\n" + "\t" + "CategoryId: " + this.CategoryId +
                "\n" + "\t" + "ModelAuto: " + this.ModelAuto +
                "\n" + "\t" + "AutoNumber: " + this.AutoNumber +
                "\n" + "\t" + "Data: " + this.Data;
        }
    }
}
