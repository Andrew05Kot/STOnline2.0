using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Interfaces.Interfaces.IServices
{
    public interface IRepairService
    {
        IEnumerable<Repair> GetAllRepairs();
        Repair GetRepairById(int Id);
        void AddRepair(Repair repair);
        void UpdateRepair(Repair repair);
        void DeleteRepair(Repair repair);
    }
}
