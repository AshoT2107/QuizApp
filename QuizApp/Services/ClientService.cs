using Microsoft.Data.Sqlite;
using QuizApp.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuizApp.Services
{
    public class ClientService
    {
        private SqliteConnection _connection;
        public ClientService() 
        {
            _connection = new SqliteConnection($"Data Source = data.db");
        }

        public void CreateTable()
        {
      
            SqliteCommand command = _connection.CreateCommand();
            command.CommandText = "CREATE TABLE IF NOT EXISTS users(" +
                "id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                "username Text," +
                "password Text," +
                "phone Text);";

            Execute(command);
        }
        public User GetUser(string username, string password)
        {
            var command = _connection.CreateCommand();
            command.CommandText = $"SELECT * FROM users WHERE username = '{username}' and password = '{password}';";
            _connection.Open();
            var data = command.ExecuteReader();
            User user = null;
            while (data.Read())
            {
                user = new User()
                {
                    Id = data.GetInt32(0),
                    UserName = data.GetString(1),
                    Password = data.GetString(2),
                    Phone = data.GetString(3),
                };
            }
            data.Close();
            _connection.Close();
            return user;
        }
        public void AddInfo(string username, string password, string phone)
        {
            var command = _connection.CreateCommand();
            command.CommandText = $"insert into users(username, password, " +
                $"phone) values ('{username}','{password}','{phone}')";
            Execute(command);
        }
        private void Execute(SqliteCommand command)
        {
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
