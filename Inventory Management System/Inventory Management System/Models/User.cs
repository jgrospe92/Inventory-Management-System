using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Inventory_Management_System.Models
{
    public class User
    {
        private String username;
        private String password;
        private String role;

        public User() { }
        public User(string username, string password, string role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role; 
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

      


        // CRUD OPERATIONS
        public async void insert()
        {
            MySqlConnection con = Helper.DbHelper.createConnection();

            con.OpenAsync().Wait();

            var cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO user(userName, password, role) VALUES(@userName, @password, @role)";
            cmd.Parameters.AddWithValue("userName", this.Username);
            cmd.Parameters.AddWithValue("password", this.Password);
            cmd.Parameters.AddWithValue("role", this.Role);

            int i = await cmd.ExecuteNonQueryAsync();
            MessageBox.Show("Done " + i);

        }
        public User get(string username)
        {
           
            MySqlConnection con = Helper.DbHelper.createConnection();
            con.OpenAsync().Wait();

            var cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM user WHERE username = @username";
            cmd.Parameters.AddWithValue("userName", username);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                MessageBox.Show("Done " + rdr.GetString(1));
                return new User(rdr.GetString(1), rdr.GetString(2), rdr.GetString(3));

            } 
            
            MessageBox.Show("Password do not match");
            return null;
        }
    }
}
