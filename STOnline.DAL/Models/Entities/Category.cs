using Newtonsoft.Json;
using STOnline.DAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace STOnline.DAL.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<WorkerCategory> WorkerCategories { get; set; }
    }
}
