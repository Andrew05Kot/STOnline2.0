using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.EntityInterfaces;
using STOnline.DAL.Interfaces.Interfaces.IServices;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.DAL.Services.Services
{
    public class ClientService: IClientService
    {
        IUnitOfWork _SqlsqlunitOfWork;
        public ClientService(IUnitOfWork sqlsqlunitOfWork)
        {
            _SqlsqlunitOfWork = sqlsqlunitOfWork;
        }

        public async Task<IEnumerable<Client>> GetAllClients()
        {
            return await _SqlsqlunitOfWork.SQLClientRepository.GetAll();
        }

        public async Task<Client> GetClientById(int id)
        {
            return await _SqlsqlunitOfWork.SQLClientRepository.GetById(id);
        }
        public async Task<Client> AddClient(Client client)
        {
            return await _SqlsqlunitOfWork.SQLClientRepository.Add(client);
        }
        public async Task<Client> UpdateClient(Client client, object obj)
        {
            return await _SqlsqlunitOfWork.SQLClientRepository.Update(client ,obj);
        }
        public async Task<int> DeleteClient(Client client)
        {
            return await _SqlsqlunitOfWork.SQLClientRepository.Delete(client);
        }
        
    }
}
