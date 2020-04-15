using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.Interfaces.IServices;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.DAL.Services.Services
{
    public class RepairService : IRepairService
    {
        IUnitOfWork _SqlsqlunitOfWork;
        public RepairService(IUnitOfWork sqlsqlunitOfWork)
        {
            _SqlsqlunitOfWork = sqlsqlunitOfWork;
        }

        public async Task<IEnumerable<Repair>> GetAllRepairs()
        {
            return await _SqlsqlunitOfWork.SQLRepairRepository.GetAll();
        }

        public async Task<Repair> GetRepairById(int Id)
        {
            return await _SqlsqlunitOfWork.SQLRepairRepository.GetById(Id);
        }
        public async Task<Repair> AddRepair(Repair repair)
        {
            return await _SqlsqlunitOfWork.SQLRepairRepository.Add(repair);
        }
        public async Task<Repair> UpdateRepair(Repair repair, object obj)
        {
            return await _SqlsqlunitOfWork.SQLRepairRepository.Update(repair, obj);
        }
        public async Task<int> DeleteRepair(Repair repair)
        {
            return await  _SqlsqlunitOfWork.SQLRepairRepository.Delete(repair);
        }

    }
}
