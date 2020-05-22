//using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using STOnline.DAL.Interfaces.EntityInterfaces;
using STOnline.DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace STOnline.DAL.Models
{
    public class Client : BaseEntity
    {
        public string ClientLastName { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientPhoneNumber { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
