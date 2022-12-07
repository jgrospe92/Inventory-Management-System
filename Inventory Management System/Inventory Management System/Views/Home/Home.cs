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

            productsDataGrid.Rows.Clear();

            foreach (Models.Product_ product in products)
            {
                int rowId = productsDataGrid.Rows.Add();
                DataGridViewRow row = productsDataGrid.Rows[rowId];
                row.Cells["productCode"].Value =  Int32.Parse(product.ProductCode);
                row.Cells["ProductName"].Value = product.ProductName;
                row.Cells["Size"].Value = product.Size;
                row.Cells["productCategory"].Value = product.Category;
                row.Cells["productStock"].Value = product.ProductQTY;
                row.Cells["minToReorder"].Value = product.MinToReorder;
                row.Cells["productLocation"].Value = product.ProdLocation;
            }
           
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            productsDataGrid.Rows.Clear();
            Controllers.ProductDAO_ productDAO = new Controllers.ProductDAO_();
            string keyword = searchTextBox.Text.Trim();
            List<Models.Product_> products = productDAO.searchByKeyWord(keyword);

            foreach (Models.Product_ product in products)
            {
                int rowId = productsDataGrid.Rows.Add();
                DataGridViewRow row = productsDataGrid.Rows[rowId];
                row.Cells["productCode"].Value = Int32.Parse(product.ProductCode);
                row.Cells["ProductName"].Value = product.ProductName;
                row.Cells["Size"].Value = product.Size;
                row.Cells["productCategory"].Value = product.Category;
                row.Cells["productStock"].Value = product.ProductQTY;
                row.Cells["minToReorder"].Value = product.MinToReorder;
                row.Cells["productLocation"].Value = product.ProdLocation;
            }
        }

        private void clearHomeButton_Click(object sender, EventArgs e)
        {
            productsDataGrid.Rows.Clear();
            loadProducts();
        }

        private void productsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productsDataGrid.Columns[e.ColumnIndex].Name == "deleteProduct")
            {
                if(MessageBox.Show("Are you sure you want to delete this item?", "WARNING", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    productsDataGrid.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
