using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Views.Report
{
    public partial class Report : Form
    {
        List<Models.Product_> products = new List<Models.Product_>();
        public Report()
        {
            InitializeComponent();
            loadProducts();
        }

        public void loadProducts()
        {
            Controllers.ProductDAO_ productDAO = new Controllers.ProductDAO_();
            products = productDAO.getAllLowStocks();

            if (products.Count < 0) { reportLabel.Visible = true; return; }

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

        Bitmap bitmap;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

     
        private void printButton_Click(object sender, EventArgs e)
        {
            //Graphics g = this.CreateGraphics();
            //bmp = new Bitmap(this.Size.Width, this.Height, g);
            //Graphics mg = Graphics.FromImage(bmp);
            //mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, productsDataGrid.Size);
            //printPreviewDialog1.ShowDialog();
            //Resize DataGridView to full height.
            int height = productsDataGrid.Height;
            productsDataGrid.Height = productsDataGrid.RowCount * productsDataGrid.RowTemplate.Height;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(this.productsDataGrid.Width, this.productsDataGrid.Height);
            productsDataGrid.DrawToBitmap(bitmap, new Rectangle(0, 0, this.productsDataGrid.Width, this.productsDataGrid.Height));
            //Resize DataGridView back to original height.
            productsDataGrid.Height = height;

            //Show the Print Preview Dialog.
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {
        
        }
    }
}
