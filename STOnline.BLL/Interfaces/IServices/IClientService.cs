using STOnline.BLL.DTOs;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace STOnline.BLL.Interfaces.IServices
{
    public interface IClientService
    {
        Task<IEnumerable<ClientDTO>> GetAllClients();
        Task<ClientDTO> GetClientById(int Id);
        Task<Client> AddClient(ClientDTO client);
        Task<Client> UpdateClient(ClientDTO client);
        Task<int> DeleteClient(ClientDTO client);
    }
}
