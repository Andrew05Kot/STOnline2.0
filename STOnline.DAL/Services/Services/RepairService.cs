using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.Interfaces.IServices;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Services.Services
{
    public class RepairService : IRepairService
    {
        IUnitOfWork _SqlsqlunitOfWork;
        public RepairService(IUnitOfWork sqlsqlunitOfWork)
        {
            _SqlsqlunitOfWork = sqlsqlunitOfWork;
        }

        public IEnumerable<Repair> GetAllRepairs()
        {
            return _SqlsqlunitOfWork.SQLRepairRepository.GetAll();
        }

        public Repair GetRepairById(int Id)
        {
            return new Repair();
        }
        public void AddRepair(Repair repair)
        {
            _SqlsqlunitOfWork.SQLRepairRepository.Add(repair);
        }
        public void DeleteRepair(Repair repair)
        {
            _SqlsqlunitOfWork.SQLRepairRepository.Delete(repair);
        }

        public void UpdateRepair(Repair repair)
        {
            _SqlsqlunitOfWork.SQLRepairRepository.Update(repair);
        }
    }
}
