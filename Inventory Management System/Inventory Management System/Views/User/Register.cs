using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Views.User
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Username_Enter_Text(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "Username")
            {
                usernameTxt.Text = "";

                usernameTxt.ForeColor = Color.Black;
            }
        }

        private void Username_Leave_Text(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "")
            {
                usernameTxt.Text = "Username";

                usernameTxt.ForeColor = Color.Silver;
            }
        }

        private void Password_Enter_Text(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "Password")
            {
                passwordTxt.Text = "";

                passwordTxt.ForeColor = Color.Black;
            }
        }

        private void Password_Leave_Text(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "")
            {
                passwordTxt.Text = "Password";

                passwordTxt.ForeColor = Color.Silver;
            }
        }
    }
}