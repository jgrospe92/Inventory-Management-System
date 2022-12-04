
using Inventory_Management_System.Helper;
using Inventory_Management_System.Views.Main;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using MySqlConnector;
using Inventory_Management_System.Models;

namespace Inventory_Management_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //ApplicationConfiguration.Initialize();
            //Application.Run(new Main());

            User labelTect = new User("Monica", "1234", "Label Technician");
            Controllers.UserDAO userDao = new Controllers.UserDAO();
            userDao.insert(labelTect);

            //    SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Ecom; Integrated Security=True");
            //    SqlDataReader rdr = null;
            //AllocConsole();
            //[DllImport("kernel32.dll", SetLastError = true)]
            //[return: MarshalAs(UnmanagedType.Bool)]
            //static extern bool AllocConsole();
            //Console.WriteLine(Properties.Settings.Default.@default);
            //Console.ReadLine();

            //    try
            //    {
            //        con.Open();

            //        SqlCommand cmd = new SqlCommand("SELECT * FROM account", con);
            //        rdr = cmd.ExecuteReader();


            //        while (rdr.Read())
            //        {
            //            Console.WriteLine(rdr[1]);

            //        }
            //        Console.ReadLine();
            //    }
            //    finally
            //    {
            //        if (rdr != null)
            //        {
            //            rdr.Close();
            //        }

            //        if (con != null)
            //        {
            //            con.Close();
            //        }
            //    }

        }
    }
}