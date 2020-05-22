using Microsoft.AspNetCore.Identity;
using STOnline.DAL.Models;
using STOnline.DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.BLL.DTOs
{
    public class ClientDTO
    {
        public int Id { get; set; }
        public string ClientLastName { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientPhoneNumber { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
