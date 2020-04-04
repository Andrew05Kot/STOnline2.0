using STOnline.DAL.DBContext;
using STOnline.DAL.Interfaces.Interfaces.IRepositories;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Repositoryes.Repositoryes
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }
    }
}
