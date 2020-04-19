using STOnline.DAL.Interfaces;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using STOnline.BLL.Interfaces.IServices;
using AutoMapper;
using STOnline.BLL.DTOs;

namespace STOnline.BLL.Services.Services
{
    public class WorkerService : IWorkerService
    {
        IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public WorkerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<WorkerDTO>> GetAllWorkers()
        {
            var data = await _unitOfWork.WorkerRepository.GetAll();
            List<WorkerDTO> transferedToDTO = new List<WorkerDTO>();
            foreach (var workers in data)
            {
                transferedToDTO.Add(_mapper.Map<Worker, WorkerDTO>(workers));
            }
            return transferedToDTO;
        }

        public async Task<WorkerDTO> GetWorkerById(int Id)
        {
            var data = await _unitOfWork.WorkerRepository.GetById(Id);
            return _mapper.Map<Worker, WorkerDTO>(data);
        }
        public async Task<Worker> AddWorker(WorkerDTO worker)
        {
            var data = _mapper.Map<WorkerDTO, Worker>(worker);
            return await _unitOfWork.WorkerRepository.Add(data);
        }
        public async Task<Worker> UpdateWorker(WorkerDTO worker)
        {
            var data = _mapper.Map<WorkerDTO, Worker>(worker);
            return await _unitOfWork.WorkerRepository.Update(data);
        }
        public async Task<int> DeleteWorker(WorkerDTO worker)
        {
            var data = _mapper.Map<WorkerDTO, Worker>(worker);
            return await  _unitOfWork.WorkerRepository.Delete(data);
        }

    }
}
