using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Views.Help
{
    public partial class HelpMenu : Form
    {
        public HelpMenu()
        {
            InitializeComponent();
        }

        private void HelpMenu_Load(object sender, EventArgs e)
        {

        }


        private void loginHelpMenuLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helpMenuLabel.Text = "How to login: \n\n Step 1: In the navigation bar to your left select the user icon \n\n Step 2: You will be redirected to the login page \n\n Step 3: Enter your username and password \n\n ** If an error occurs, contact your Lab Technician";
        }

        private void createHelpMenuLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helpMenuLabel.Text = "How to create a new product: \n\n Step 1: In the navigation bar to your left select the file icon \n\n Step 2: You will be redirected to the create page \n\n Step 3: Fill the information using the empty spaces and press Create. \n\n ** An error occurs when the Code and Lot Number already exists. \n Products must have a unique Code and Lot Number.";
        }

        private void updateHelpMenuLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helpMenuLabel.Text = "How to update an existing product: \n\n Step 1: In the navigation bar to your left select the home icon \n\n Step 2: You will be redirected to the Homepage \n\n Step 3: In the Homepage’s table you will see an option \n to check mark which item you wish to update \n\n Step 4:  After check marking, a screen will pop up \n\n Step 5:  Fill in the changes and press update";
        }

        private void deleteHelpMenuLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helpMenuLabel.Text = "How to delete a product: \n\n Step 1: In the navigation bar to your left select the home icon \n\n Step 2: You will be redirected to the Homepage \n\n Step 3: In the Homepage’s table you will see an option to delete (X). \n\n Step 4:  After check marking, a screen will pop up \n\n Step 5:  A prompt will appear to ask your confirmation before deletion";
        }
    }
}
