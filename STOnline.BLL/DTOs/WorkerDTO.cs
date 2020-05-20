using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.BLL.DTOs
{
    public class WorkerDTO
    {
        public int Id { get; set; }
        public string WorkeLastName { get; set; }
        public string WorkerFirstName { get; set; }
        public string WorkerPhoneNumber { get; set; }
        public ICollection<WorkerCategoryDTO> WorkerCategories { get; set; }
        public ICollection<RepairDTO> Repairs { get; set; }
    }
}
