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

namespace Inventory_Management_System.Views.Main
{
    public partial class Main : Form
    {

        Boolean sideBarExtend;
        Bitmap openIcon = new Bitmap(Resource.menu);
        Bitmap closeIcon = new Bitmap(Resource.close);

        Bitmap noAlert = new Bitmap(Resource.bell_ring);
        Bitmap hasAlert = new Bitmap(Resource.notification);

        Button currentButton;

        public Main()
        {
            InitializeComponent();
            menuButton.Image = openIcon;
            alertButton.Image = noAlert;
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
        
            currentButton.BackColor = Color.FromArgb(52, 56, 57);
   
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
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            activeButton(sender);
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            activeButton(sender);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            activeButton(sender);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            activeButton(sender);
        }
    }
}
