using STOnline.BLL.Interfaces.IServices;
using STOnline.DAL.Interfaces;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.BLL.Services.Services
{
    public class RepairService : IRepairService
    {
        IUnitOfWork _unitOfWork;
        public RepairService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Repair>> GetAllRepairs()
        {
            return await _unitOfWork.RepairRepository.GetAll();
        }

        public async Task<Repair> GetRepairById(int Id)
        {
            return await _unitOfWork.RepairRepository.GetById(Id);
        }
        public async Task<Repair> AddRepair(Repair repair)
        {
            return await _unitOfWork.RepairRepository.Add(repair);
        }
        public async Task<Repair> UpdateRepair(Repair repair, object obj)
        {
            return await _unitOfWork.RepairRepository.Update(repair, obj);
        }
        public async Task<int> DeleteRepair(Repair repair)
        {
            return await  _unitOfWork.RepairRepository.Delete(repair);
        }

    }
}
