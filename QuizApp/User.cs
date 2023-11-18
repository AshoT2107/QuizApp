using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public class User
    {
        public User(string username, string password, string phone)
        {
            UserName= username;
            Password= password;
            Phone= phone;
        }
        
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }

        public User()
        {

        }
    }
}
