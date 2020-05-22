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
    public class ClientService : IClientService
    {
        IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ClientService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClientDTO>> GetAllClients()
        {
            var data = await _unitOfWork.ClientRepository.GetAll();
            List<ClientDTO> transferedToDTO = new List<ClientDTO>();
            foreach (var clients in data)
            {
                transferedToDTO.Add(_mapper.Map<Client, ClientDTO>(clients));
            }
            return transferedToDTO;
        }

        public async Task<ClientDTO> GetClientById(int id)
        {
            var data = await _unitOfWork.ClientRepository.GetById(id);
            return _mapper.Map<Client, ClientDTO>(data);
        }
        public async Task<Client> AddClient(ClientDTO client)
        {
            var data = _mapper.Map<ClientDTO, Client>(client);
            return await _unitOfWork.ClientRepository.Add(data);
        }
        public async Task<Client> UpdateClient(ClientDTO client)
        {
            var data = _mapper.Map<ClientDTO, Client>(client);
            return await _unitOfWork.ClientRepository.Update(data);
        }
        public async Task<int> DeleteClient(ClientDTO client)
        {
            var data = _mapper.Map<ClientDTO, Client>(client);
            return await _unitOfWork.ClientRepository.Delete(data);
        }

    }
}
