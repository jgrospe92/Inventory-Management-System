using Inventory_Management_System.Properties;
using Inventory_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Inventory_Management_System.Views.Main
{
    public partial class Main : Form
    {

        Boolean sideBarExtend;
        Bitmap openIcon = new Bitmap(Resource.menu);
        Bitmap closeIcon = new Bitmap(Resource.close);

        Bitmap noAlert = new Bitmap(Resource.bell_ring);
        Bitmap hasAlert = new Bitmap(Resource.notification);

        Button currentButton = null;
        Form activeForm;

        bool hasActiveUser = false;

        public Main()
        {
            InitializeComponent();
            menuButton.Image = openIcon;
            alertButton.Image = noAlert;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void openChild(Form childForm, Object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.containerPanel.Controls.Add(childForm);
            this.containerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            titleLabel.Text = childForm.Text;
        }


        private void sideBarTimer_tick(object sender, EventArgs e)
        {
            if (sideBarExtend)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width) 
                {
                    sideBarExtend = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sideBarExtend = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void activeButton(Object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button) btnSender)
                {
           
                    Color activeBackColor = Color.FromArgb(174, 176, 176);
                    currentButton = (Button) btnSender;
                    currentButton.BackColor = activeBackColor;
                }
            }
        }

        private void deactiveButton(object sender, EventArgs e)
        {
               if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(52, 56, 57);
            }
          
        }

        private void menuButton_Click(object sender, EventArgs e)
        {

         
            if (menuButton.Image == openIcon)
            {
                menuButton.Image = closeIcon;
            } else
            {
                menuButton.Image = openIcon;
            }
         
            sidebarTimer.Start();
        }

        private void alertButton_Click(object sender, EventArgs e)
        {
            activeButton(sender);

            if (alertButton.Image == noAlert)
            {
                alertButton.Image = hasAlert;
            }
            else
            {
                alertButton.Image = noAlert;
            }

            openChild(new Views.Product.Notification(), sender);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            openChild(new Views.Home.Home(), sender);
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            openChild(new Views.Product.ProductDetails(), sender);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            activeButton(sender);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
          
            openChild(new Views.Help.HelpMenu(), sender);
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }
    }
}
