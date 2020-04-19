using Newtonsoft.Json;
using STOnline.DAL.Interfaces.EntityInterfaces;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace STOnline.DAL.Models
{
    public class Order : BaseEntity
    {
        public Client Client { get; set; }
        [Required]
        public int ClientId { get; set; }
        public Category Category { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string ModelAuto { get; set; }
        [Required]
        public string AutoNumber { get; set; }
        public DateTime Data { get; set; }

        [ForeignKey("OrderId")]
        public ICollection<Repair> Repairs { get; set; }

    }
}
