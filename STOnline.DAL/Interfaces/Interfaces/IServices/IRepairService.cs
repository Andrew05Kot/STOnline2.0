using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.DAL.Interfaces.Interfaces.IServices
{
    public interface IRepairService
    {
        IEnumerable<Repair> GetAllRepairs();
        Task<Repair> GetRepairById(int Id);
        Task<Repair> AddRepair(Repair repair);
        Task<Repair> UpdateRepair(Repair repair, object obj);
        Task<int> DeleteRepair(Repair repair);
    }
}
