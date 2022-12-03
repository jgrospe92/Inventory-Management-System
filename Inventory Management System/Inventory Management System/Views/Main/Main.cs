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
        public Main()
        {
            InitializeComponent();
            menuButton.Image = openIcon;
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
    }
}
