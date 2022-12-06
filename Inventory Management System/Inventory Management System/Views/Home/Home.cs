﻿using System;
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

        
            foreach(Models.Product_ product in products)
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

    }
}
