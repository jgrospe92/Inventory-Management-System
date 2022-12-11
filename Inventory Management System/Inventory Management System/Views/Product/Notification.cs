using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Views.Product
{
    public partial class Notification : Form
    {

        List<Models.Product_> products = new List<Models.Product_>();
        public Notification()
        {
            InitializeComponent();
            loadProducts();
        }

        private void Notification_Load(object sender, EventArgs e)
        {

        }

        public void loadProducts()
        {
            Controllers.ProductDAO_ productDAO = new Controllers.ProductDAO_();
            products = productDAO.getAllLowStocks();

            if (products.Count < 0) { notificationLabel.Visible = true; return; }

            productsDataGrid.Rows.Clear();

            foreach (Models.Product_ product in products)
            {
                int rowId = productsDataGrid.Rows.Add();
                DataGridViewRow row = productsDataGrid.Rows[rowId];
                row.Cells["product_ID"].Value = product.Product_ID;
                row.Cells["productCode"].Value = Int32.Parse(product.ProductCode);
                row.Cells["ProductName"].Value = product.ProductName;
                row.Cells["Size"].Value = product.Size;
                row.Cells["productCategory"].Value = product.Category;
                row.Cells["productStock"].Value = product.ProductQTY;
                row.Cells["minToReorder"].Value = product.MinToReorder;
                row.Cells["productLocation"].Value = product.ProdLocation;
            }

        }
    }
}
