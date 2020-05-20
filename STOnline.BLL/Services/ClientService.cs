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

        public async Task<IEnumerable<Client>> GetAllClients()
        {
            var data = await _unitOfWork.ClientRepository.GetAll();
            List<Client> transferedToDTO = new List<Client>();
            foreach (var clients in data)
            {
                transferedToDTO.Add(_mapper.Map<Client, Client>(clients));
            }
            return transferedToDTO;
        }

        public async Task<Client> GetClientById(int id)
        {
            var data = await _unitOfWork.ClientRepository.GetById(id);
            return _mapper.Map<Client, Client>(data);
        }
        public async Task<Client> AddClient(Client client)
        {
            var data = _mapper.Map<Client, Client>(client);
            return await _unitOfWork.ClientRepository.Add(data);
        }
        public async Task<Client> UpdateClient(Client client)
        {
            var data = _mapper.Map<Client, Client>(client);
            return await _unitOfWork.ClientRepository.Update(data);
        }
        public async Task<int> DeleteClient(Client client)
        {
            var data = _mapper.Map<Client, Client>(client);
            return await _unitOfWork.ClientRepository.Delete(data);
        }

    }
}
