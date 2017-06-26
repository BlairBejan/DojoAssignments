using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using ECommerce.Models;
 
namespace ECommerce.Factory
{
    public class CustomerFactory : IFactory<Customer>
    {
        private string connectionString;
        public CustomerFactory()
        {
            connectionString = "server=localhost;userid=root;password=root;port=8887;database=ecommerce;SslMode=None";
        }
        internal IDbConnection Connection
        {
            get {
                return new MySqlConnection(connectionString);
            }
        }
    }
}