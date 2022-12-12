using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Views.Product
{
    public partial class Update : Form
    {

        int product_ID;
        DataGridView cuurentProductData;
        public Update(int product_ID, DataGridView data)
        {
            InitializeComponent();
            this.product_ID = product_ID;
            this.cuurentProductData = data;
      
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            errorLabelUpdate.Text = "";
            Regex regex = new Regex(@"^\d+$");
            if (!regex.IsMatch(qtyTextBox.Text.Trim())) { errorLabelUpdate.Text = "Invalid input"; return; }
            if (qtyTextBox.Text == "" || qtyTextBox.Text == "0") { return; }
            
            Controllers.ProductDAO_ prodHelper = new Controllers.ProductDAO_();
            Models.Product_ product = prodHelper.get(product_ID);
            int valueToRemove = Int32.Parse(qtyTextBox.Text.Trim());
            if (product.ProductQTY < valueToRemove) { errorLabelUpdate.Text = product.ProductQTY + " remaining"; return;  }
            product.ProductQTY = product.ProductQTY - valueToRemove;
            // TODO: If productQTY is 0, insert it to report and notification table
            prodHelper.updateProdQTY(product);
            if(product.ProductQTY < product.MinToReorder) { product.insertToNotif(product.Product_ID); }
            cuurentProductData.CurrentRow.Cells["productStock"].Value = product.ProductQTY;
            this.Close();
        }

        private void cancelButtonUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void qtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("You must enter a numeric value!");
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        

    }
}
