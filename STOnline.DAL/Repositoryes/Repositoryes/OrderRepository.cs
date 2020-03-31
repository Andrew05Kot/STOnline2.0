﻿
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
using STOnline.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using STOnline.DAL.Interfaces.EntityInterfaces;
using STOnline.DAL.DBContext;
using STOnline.DAL.Model;

namespace STOnline.Repositoryes
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(IConnectionFactory connectionFactory, ApplicationContext applicationContext) : base(connectionFactory, applicationContext)
        {
            connectionFactory.SetConnection("server = ANDREYKOT\\SQLEXPRESS; Initial Catalog = STOnline; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }

    }
}
