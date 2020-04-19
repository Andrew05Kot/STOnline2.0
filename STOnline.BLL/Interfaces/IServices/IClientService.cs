using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.BLL.Interfaces.IServices
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetAllClients();
        Task<Client> GetClientById(int Id);
        Task<Client> AddClient(Client client);
        Task<Client> UpdateClient(Client client, object key);
        Task<int> DeleteClient(Client client);
    }
}
