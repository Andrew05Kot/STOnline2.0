using STOnline.BLL.DTOs;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.BLL.Interfaces.IServices
{
    public interface IRepairService
    {
        Task<IEnumerable<RepairDTO>> GetAllRepairs();
        Task<RepairDTO> GetRepairById(int Id);
        Task<Repair> AddRepair(RepairDTO repair);
        Task<Repair> UpdateRepair(RepairDTO repair);
        Task<int> DeleteRepair(RepairDTO repair);
    }
}
