using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace STOnline.WEB.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string PhoneNumbrer { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
