using System;
using System.Collections.Generic;
using System.Linq;
using MySqlConnector;
using Inventory_Management_System.Models;
using System.Drawing;


namespace Inventory_Management_System.Controllers
{
    public class UserDAO : Controllers.DataAccessObject
    {

        public void delete()
        {
            throw new NotImplementedException();
        }

        public void get()
        {
            throw new NotImplementedException();
        }

        public void getAll()
        {
            throw new NotImplementedException();
        }

        public async void insert(User user)
        {
            MySqlConnection con = Helper.DbHelper.createConnection();

            con.OpenAsync().Wait();

            var cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO user(userName, password, role) VALUES(@userName, @password, @role)";
            cmd.Parameters.AddWithValue("userName", user.Username);
            cmd.Parameters.AddWithValue("password", user.Password);
            cmd.Parameters.AddWithValue("role", user.Role);

            int i = await cmd.ExecuteNonQueryAsync();
            MessageBox.Show("Done " + i);

        }

        public void testCreate()
        {

            MySqlConnection con = Helper.DbHelper.createConnection();
            string createTable = "create table test(id int, name varchar(20))";
            MySqlCommand cmd = new MySqlCommand(createTable, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show("Success " + i.ToString());
            MessageBox.Show("hello world");
        }
        public void update()
        {
            throw new NotImplementedException();
        }
    }
}
