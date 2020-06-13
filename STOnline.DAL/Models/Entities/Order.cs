using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using STOnline.DAL.Interfaces.EntityInterfaces;
using STOnline.DAL.Models;
using STOnline.DAL.Models.Entities;
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
        //public Client Client { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }
        public string ModelAuto { get; set; }
        public string AutoNumber { get; set; }
        public DateTime Data { get; set; }
        public string ImageUrl { get; set; }
    }
}
