using STOnline.DAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Models
{
    public class Category : IEntity<int>
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public Category(int id, string category)
        {
            this.Id = id;
            this.CategoryName = category;
        }
        public Category(string category)
        {
            this.CategoryName = category;
        }
        public Category() { }
        public override string ToString()
        {
            return "CategoryId: " + this.Id +
                "\n" + "\t" + "Category: " + this.CategoryName;
        }
    }
}
