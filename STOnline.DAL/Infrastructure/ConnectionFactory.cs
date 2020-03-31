using STOnline.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace STOnline.DAL.Infrastructure
{
    public class ConnectionFactory : IConnectionFactory
    {
        private static string _connectionString;

        public IDbConnection GetSqlConnection
        {
            get
            {
                SqlConnection connection;

                if (!string.IsNullOrEmpty(_connectionString))
                    connection = new SqlConnection(_connectionString);
                else
                    connection = new SqlConnection(connectionString: ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

                connection.Open();

                return connection;
            }
        }

        public void SetConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

    }
}
