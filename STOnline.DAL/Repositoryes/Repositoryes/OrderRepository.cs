
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using STOnline.DAL.Repositoryes;
using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.EntityInterfaces;
using STOnline.DAL.DBContext;
using STOnline.DAL.Models;
using Microsoft.Extensions.Configuration;
using STOnline.DAL.Interfaces.Interfaces.IRepositories;

namespace STOnline.DAL.Repositoryes.Repositoryes
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

    }
}
