using STOnline.BLL.Interfaces.IServices;
using STOnline.DAL.Interfaces;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.BLL.Services.Services
{
    public class ClientService: IClientService
    {
        IUnitOfWork _unitOfWork;
        public ClientService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Client>> GetAllClients()
        {
            return await _unitOfWork.ClientRepository.GetAll();
        }

        public async Task<Client> GetClientById(int id)
        {
            return await _unitOfWork.ClientRepository.GetById(id);
        }
        public async Task<Client> AddClient(Client client)
        {
            return await _unitOfWork.ClientRepository.Add(client);
        }
        public async Task<Client> UpdateClient(Client client, object obj)
        {
            return await _unitOfWork.ClientRepository.Update(client ,obj);
        }
        public async Task<int> DeleteClient(Client client)
        {
            return await _unitOfWork.ClientRepository.Delete(client);
        }
        
    }
}
