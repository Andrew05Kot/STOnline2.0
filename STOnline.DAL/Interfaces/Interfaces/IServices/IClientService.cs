using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Interfaces.Interfaces.IServices
{
    public interface IClientService
    {
        IEnumerable<Client> GetAllClients();
        Client GetClientById(int Id);
        void AddClient(Client client);
        void UpdateClient(Client client);
        void DeleteClient(Client client);
    }
}
