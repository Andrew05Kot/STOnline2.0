using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.Interfaces.IServices;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Services.Services
{
    public class ClientService: IClientService
    {
        IUnitOfWork _SqlsqlunitOfWork;
        public ClientService(IUnitOfWork sqlsqlunitOfWork)
        {
            _SqlsqlunitOfWork = sqlsqlunitOfWork;
        }

        public IEnumerable<Client> GetAllClients()
        {
            return _SqlsqlunitOfWork.SQLClientRepository.GetAll();
        }

        public Client GetClientById(int Id)
        {
            return new Client();
        }
        public void AddClient(Client client)
        {
            _SqlsqlunitOfWork.SQLClientRepository.Add(client);
        }
        public void DeleteClient(Client client)
        {
            _SqlsqlunitOfWork.SQLClientRepository.Delete(client);
        }

        public void UpdateClient(Client client)
        {
            _SqlsqlunitOfWork.SQLClientRepository.Update(client);
        }
    }
}
