using STOnline.DAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace STOnline.DAL.Models
{
    public class BaseEntity : IEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
