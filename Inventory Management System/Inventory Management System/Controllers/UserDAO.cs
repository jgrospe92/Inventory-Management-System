using System;
using System.Collections.Generic;
using System.Linq;
using MySqlConnector;
using Inventory_Management_System.Models;
using System.Drawing;
using System.Collections;

namespace Inventory_Management_System.Controllers
{
    public class UserDAO : Controllers.DataAccessObject<User>
    {

        User user;

        public UserDAO() { user = new User();}

        public UserDAO(User user)
        {
            this.user = user;
        }

        public bool delete(int userID)
        {
            throw new NotImplementedException();
        }

        public User get(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> getAll()
        {
            throw new NotImplementedException();
        }

        public void insert()
        {
            user.insert();
        }

        public bool update(int userID)
        {
            throw new NotImplementedException();
        }

        public User checkCredentials(string username, string password)
        {
            
            User userCheck = user.get(username);
            if (userCheck == null) { return null; }

            bool verifyPasswordHashed = Helper.LockPickHelper.VerifyPassword(userCheck.Password, password);
            if (!verifyPasswordHashed) { return null;}
    
            return userCheck;
        }
    }
}
