using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventory_Management_System.Views.Product
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        // Insert new product
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            Models.Product_ product = new Models.Product_();
            Controllers.ProductDAO_ productDAO = new Controllers.ProductDAO_(product);

            if (!validateTextBox(tb_lotNumberAdd) || !validateTextBox(cb_codeAdd) || !validateTextBox(tb_nameAdd)
                || !validateTextBox(tb_qtyAdd) || !validateTextBox(tb_sizeWidthAdd) || !validateTextBox(tb_sizeHeightAdd)
                || !validateTextBox(tb_locationAdd) || !validateTextBox(cb_codeAdd) || !validateTextBox(tb_qtyAdd)
                || !validateTextBox(tb_minToOrderAdd) || !validateComboBox(cb_categoryAdd) || !validateComboBox(cb_typeAdd)
                || !validateComboBox(cb_productStatusAdd) || !validateComboBox(cb_inventoryStatusAdd))
            {

                MessageBox.Show("Please provide all info or type NA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            product.ProductLotNum = tb_lotNumberAdd.Text;
            product.ProductCode = cb_codeAdd.Text;
            product.ProductName = tb_nameAdd.Text;
            product.ProductQTY = Int32.Parse(tb_qtyAdd.Text);
            product.Size = tb_sizeWidthAdd.Text + "x" + tb_sizeHeightAdd.Text;
            product.Category = cb_categoryAdd.Text;
            product.MinToReorder = Int32.Parse(tb_minToOrderAdd.Text);
            product.ProdLocation = tb_locationAdd.Text;
            product.ProductType = cb_typeAdd.Text;
            product.ProductStatus = cb_productStatusAdd.Text;
            DateTime current = DateTime.Now;
            product.DateAdded = current;
            product.LastUpdated = current;
            product.InventoryStatus = cb_inventoryStatusAdd.SelectedItem.ToString();
            
            productDAO.insert();
            MessageBox.Show("New Item Added");
            ClearTextBoxes(this);
        }

        private Boolean validateTextBox(TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
            {
                return false;
            }
            return true;
        }

       

        private void tb_sizeWidthAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                MessageBox.Show("You must enter a numeric value!");
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_sizeHeigthAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("You must enter a numeric value!");
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void cb_codeAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("You must enter a numeric value!");
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tb_minToOrderAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("You must enter a numeric value!");
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_qtyAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("You must enter a numeric value!");
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }



        private Boolean validateComboBox(ComboBox comboBox)
        {
            if (String.IsNullOrEmpty(comboBox.Text))
            {
                return false;
            }
            return true;
        }

        private void ClearTextBoxes(Control control)
        {
            foreach (var c in control.Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = String.Empty;
                if (c is ComboBox) ((ComboBox)c).SelectedItem = null;
            }
        }


        private string checkCMBifNull(ComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                string? category = comboBox.SelectedItem.ToString();
                return category;
            }
            return "OTHER";
        }

        private string checkCMBStatus(ComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                string? status = comboBox.SelectedItem.ToString();
                return status;
            }
            return "ACTIVE";
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
        }

        private void tb_lotNumberAdd_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
