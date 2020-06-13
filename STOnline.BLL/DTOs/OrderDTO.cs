using Microsoft.AspNetCore.Http;
using STOnline.DAL.Models;
using STOnline.DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.BLL.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        //public Client Client { get; set; }
        public User User { get; set; }
        public ICollection<CategoryDTO> Categories { get; set; }
        public string ModelAuto { get; set; }
        public string AutoNumber { get; set; }
        public DateTime Data { get; set; }
        public string ImageUrl { get; set; }
    }
}
