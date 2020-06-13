using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Models.Entities
{
    public class User: IdentityUser<int>
    {
        public string FullName { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
