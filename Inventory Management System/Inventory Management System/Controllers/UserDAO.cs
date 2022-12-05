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

        User user;

        public UserDAO() { user = new User();}

        public UserDAO(User user)
        {
            this.user = user;
        }

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

        public void insert()
        {
            user.insert();
        }

        public void update()
        {
            throw new NotImplementedException();
        }

        public bool checkCredentials(string username, string password)
        {
            
            User userCheck = user.get(username);
            if (userCheck == null) { return false; }

            bool verifyPasswordHashed = Helper.LockPickHelper.VerifyPassword(userCheck.Password, password);
            if (!verifyPasswordHashed) { return false;}
    
            return true;
        }
    }
}
