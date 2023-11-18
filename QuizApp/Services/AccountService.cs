using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Services
{
    public class AccountService
    {
        private SqliteConnection _connection;
        private SqliteCommand _command;
        public AccountService() 
        {
            _connection = new SqliteConnection($"Data Source = data.db");
            _command = _connection.CreateCommand();
            CreateTable("users");
        }

        public void CreateTable(string tableName)
        {
            SqliteCommand command = _connection.CreateCommand();
            command.CommandText = $"CREATE TABLE IF NOT EXISTS {tableName}(" +
                "id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                "username Text," +
                "password Text," +
                "phone Text);";

            Execute(command);
        }
        public User? GetUser(string username, string password)
        {
            _command.CommandText = $"SELECT * FROM users WHERE username = '{username}' and password = '{password}';";
            _connection.Open();
            var data = _command.ExecuteReader();
            User? user = null;
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


        public User? GetUser(int userId)
        {
            _command.CommandText = $"SELECT * FROM users WHERE id = '{userId}';";
            _connection.Open();
            var data = _command.ExecuteReader();
            User? user = null;
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
            var _command = _connection.CreateCommand();
            _command.CommandText = $"insert into users(username, password, " +
                $"phone) values ('{username}','{password}','{phone}')";
            Execute(_command);
        }
        private void Execute(SqliteCommand command)
        {
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
