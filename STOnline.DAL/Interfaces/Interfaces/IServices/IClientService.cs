using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.DAL.Interfaces.Interfaces.IServices
{
    public interface IClientService
    {
        IEnumerable<Client> GetAllClients();
        Task<Client> GetClientById(int Id);
        void AddClient(Client client);
        void UpdateClient(Client client);
        void DeleteClient(Client client);
    }
}
