using AutoMapper;
using STOnline.BLL.DTOs;
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
        private readonly IMapper _mapper;

        public RepairService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RepairDTO>> GetAllRepairs()
        {
            var data = await _unitOfWork.RepairRepository.GetAll();
            List<RepairDTO> transferedToDTO = new List<RepairDTO>();
            foreach (var repairs in data)
            {
                transferedToDTO.Add(_mapper.Map<Repair, RepairDTO>(repairs));
            }
            return transferedToDTO;
        }

        public async Task<RepairDTO> GetRepairById(int Id)
        {
            var data = await _unitOfWork.RepairRepository.GetById(Id);
            return _mapper.Map<Repair, RepairDTO>(data);
        }
        public async Task<Repair> AddRepair(RepairDTO repair)
        {
            var data = _mapper.Map<RepairDTO, Repair>(repair);
            return await _unitOfWork.RepairRepository.Add(data);
        }
        public async Task<Repair> UpdateRepair(RepairDTO repair)
        {
            var data = _mapper.Map<RepairDTO, Repair>(repair);
            return await _unitOfWork.RepairRepository.Update(data);
        }
        public async Task<int> DeleteRepair(RepairDTO repair)
        {
            var data = _mapper.Map<RepairDTO, Repair>(repair);
            return await  _unitOfWork.RepairRepository.Delete(data);
        }

    }
}
