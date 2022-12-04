using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    public class User
    {
        private String username;
        private String password;
        private String role;

        public User(string username, string password, string role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role; 
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
