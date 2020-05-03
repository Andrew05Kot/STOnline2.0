using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace STOnline.DAL.Interfaces
{
    public interface IConnectionFactory
    {
        IDbConnection GetSqlConnection { get; }
        void SetConnection(string connectionString);
    }
}цвцв
