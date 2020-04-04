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
    public class Category : BaseEntity
    {
        [Required]
        public string CategoryName { get; set; }
        [ForeignKey("CategoryId")]
        public ICollection<Order> Orders { get; set; }
        [ForeignKey("CategoryId")]
        public ICollection<WorkerCategory> WorkerCategories { get; set; }
    }
}
