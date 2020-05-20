using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.BLL.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<OrderDTO> Orders { get; set; }
        public ICollection<WorkerCategoryDTO> WorkerCategories { get; set; }

    }
}
