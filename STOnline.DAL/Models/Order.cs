using Newtonsoft.Json;
using STOnline.DAL.Interfaces.EntityInterfaces;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace STOnline.DAL.Model
{
    public class Order : BaseEntity
    {
        [Required]
        [JsonIgnore]
        [ForeignKey("ClientId")]
        public List<Client> Clients { get; set; }
        [JsonIgnore]
        public Guid ClientId { get; set; }
        [JsonIgnore]
        [ForeignKey("CategoryId")]
        public List<Category> Categories { get; set; }
        [JsonIgnore]
        public Guid CategoryId { get; set; }
        [Required]
        public string ModelAuto { get; set; }
        [Required]
        public string AutoNumber { get; set; }
        public DateTime Data { get; set; }

        //public Order(int id, int clientId, int categoryId, string modelAuto, string autoNumber, DateTime data)
        //{
        //    this.Id = id;
        //    this.ClientId = clientId;
        //    this.CategoryId = categoryId;
        //    this.ModelAuto = modelAuto;
        //    this.AutoNumber = autoNumber;
        //    this.Data = data;
        //}
        //public Order(int clientId, int categoryId, string modelAuto, string autoNumber, DateTime data)
        //{
        //    this.ClientId = clientId;
        //    this.CategoryId = categoryId;
        //    this.ModelAuto = modelAuto;
        //    this.AutoNumber = autoNumber;
        //    this.Data = data;
        //}
        //public Order() { }
        //public override string ToString()
        //{
        //    return "OrderId: " + this.Id +
        //        "\n" + "\t" + "ClientId: " + this.ClientId +
        //        "\n" + "\t" + "CategoryId: " + this.CategoryId +
        //        "\n" + "\t" + "ModelAuto: " + this.ModelAuto +
        //        "\n" + "\t" + "AutoNumber: " + this.AutoNumber +
        //        "\n" + "\t" + "Data: " + this.Data;
        //}
    }
}
