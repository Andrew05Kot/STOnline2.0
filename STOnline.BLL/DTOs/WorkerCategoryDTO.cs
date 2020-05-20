using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.BLL.DTOs
{
    public class WorkerCategoryDTO
    {
        public int Id { get; set; }
        public WorkerDTO Worker { get; set; }
        public CategoryDTO Category { get; set; }
    }
}
