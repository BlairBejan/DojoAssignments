using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Productivity_Cards.Models;
using Dapper;
using System.Linq;

namespace Productivity_Cards.Factories{
    public class UserFactory{
        static string server = "localhost";
        static string db = "productivity_cards";
        static string port = "8887";
        static string user = "root";
        static string pass = "root";
        internal static IDbConnection Connection {
            get {
                return new MySqlConnection($"Server={server};Port={port};Database={db};UserID={user};Password={pass};SslMode=None");
            }
        }

        public void AddUser(User user){
            using (IDbConnection dbConnection = Connection)
            {
                string query = $"INSERT INTO users (first_name, last_name, alias, email, password, created_at, updated_at) VALUES ('{user.first_name}', '{user.last_name}', '{user.alias}', '{user.email}', '{user.password}', NOW(), NOW())";
                dbConnection.Open();
                dbConnection.Execute(query);
            }
        }

        public User GetUserByEmail(string email){
            using(IDbConnection dbConnection = Connection){
                string query = $"SELECT * FROM users WHERE (email = '{email}')";
                dbConnection.Open();
                return dbConnection.QuerySingleOrDefault<User>(query);
            }
        }

    }
}