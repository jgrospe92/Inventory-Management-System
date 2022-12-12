using Microsoft.Extensions.DependencyInjection;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Helper
{
    internal class DbHelper
    {

        private static MySqlConnection conn;

      
        // Singleton class
        public static MySqlConnection createConnection()
        {
            if (conn == null)
            {
                try
                {
                    conn = new MySqlConnection(Properties.Settings.Default.rh);
                }
                
                catch (MySqlException ex)
                {
                    MessageBox.Show("Faield to connect to the datavase");
                }
            }
            return conn;
        }

        public static void DispposeConn() => conn?.Dispose();
    }
}
