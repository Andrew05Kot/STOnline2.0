using STOnline.DAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Models
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
    }
}
