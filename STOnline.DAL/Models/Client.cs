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
    public class Client : BaseEntity
    {
        [Required]
        public string ClientLastName { get; set; }
        [Required]
        public string ClientFirstName { get; set; }
        [Required]
        public string ClientPhoneNumber { get; set; }
        [Required]
        public string ClientEmail { get; set; }
        [Required]
        public string ClientPassword { get; set; }
        [ForeignKey("ClientId")]
        [NotMapped]
        public ICollection<Order> Orders { get; set; }


    }
}
