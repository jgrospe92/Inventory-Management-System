using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Views.Home
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            loadProducts();
        }

        public void loadProducts()
        {
            Controllers.ProductDAO_ productDAO = new Controllers.ProductDAO_();
            List<Models.Product_> products = productDAO.getAll();

        

           
        }

    }
}
