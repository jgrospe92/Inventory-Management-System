using Inventory_Management_System.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Views.Home
{
    public partial class Home : Form
    {
        Models.User currentUser;
        List<Models.Product_> products = new List<Models.Product_>();
        public Home(Models.User user)
        {
            InitializeComponent();
            this.currentUser =  user;
            loadProducts();
        }
     
        public void loadProducts()
        {
            Controllers.ProductDAO_ productDAO = new Controllers.ProductDAO_();
            products = productDAO.getAll();

            productsDataGrid.Rows.Clear();

            foreach (Models.Product_ product in products)
            {
                int rowId = productsDataGrid.Rows.Add();
                DataGridViewRow row = productsDataGrid.Rows[rowId];
                row.Cells["product_ID"].Value = product.Product_ID;
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

        private void clearHomeButton_Click(object sender, EventArgs e)
        {
            productsDataGrid.Rows.Clear();
            loadProducts();
        }

        private void productsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            if (currentUser.Role == "Packaging")
            {
                if (productsDataGrid.Columns[e.ColumnIndex].Name == "productEdit")
                {
                    
                    int i = Int32.Parse(productsDataGrid.CurrentRow.Cells["product_ID"].Value.ToString());
                    Product.Update update = new Product.Update(i, productsDataGrid);
                    update.Show();
                    return;
                }
                return;
            }
            if (currentUser.Role == "Order")
            {
                return;
            }
            if (productsDataGrid.Columns[e.ColumnIndex].Name == "deleteProduct")
            {
                if(MessageBox.Show("Are you sure you want to delete this item?", "WARNING", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                    string i = productsDataGrid.CurrentRow.Cells["product_ID"].Value.ToString();
                    Controllers.ProductDAO_ productHelper = new Controllers.ProductDAO_();
                    if (productHelper.delete(Int32.Parse(i)))
                    {
                        productsDataGrid.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("DONE");
                    } else
                    {
                        MessageBox.Show("Failed to delete product");
                    }
                }
            }

            if (productsDataGrid.Columns[e.ColumnIndex].Name == "productEdit")
            {
              
                Product_ product = new Product_();
                product.ProductName = productsDataGrid.CurrentRow.Cells["ProductName"].Value.ToString();
                Product.UpdateProduct updateForm = new Product.UpdateProduct(productsDataGrid);
                updateForm.Show();
               

            }
        }
    }
}
