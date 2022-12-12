using Inventory_Management_System.Models;
using MySqlX.XDevAPI.Relational;
using System.Data;

namespace Inventory_Management_System.Views.Product
{
    public partial class UpdateProduct : Form
    {

        Models.Product_ product;
        DataGridView data;
        public UpdateProduct(DataGridView data)
        {
            InitializeComponent();
            this.data = data;
            loadData();
        }

        public void loadProduct(Models.Product_ product)
        {
            this.product = product;
           
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void tb_sizeWidthUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("You must enter a numeric value!");
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_sizeHeigthUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("You must enter a numeric value!");
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void cb_codeUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("You must enter a numeric value!");
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tb_minToOrderUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("You must enter a numeric value!");
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_qtyUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("You must enter a numeric value!");
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
            product.ProductName = tb_nameUpdate.Text;
            product.ProductLotNum = tb_lotNumberUpdate.Text;
            product.Size = tb_sizeWidthUpdate.Text + "x" + tb_sizeHeightUpdate.Text;
            product.ProdLocation = tb_locationUpdate.Text;
            product.Category = cb_categoryUpdate.Text;
            product.ProductCode = cb_codeUpdate.Text;
            product.ProductQTY = Int32.Parse(tb_qtyUpdate.Text);
            product.ProductType = cb_typeUpdate.Text;
            product.ProductStatus = cb_productStatusUpdate.Text;
            DateTime current = DateTime.Now;
            product.LastUpdated = current;
            product.MinToReorder = Int32.Parse(tb_minToOrderUpdate.Text);
            product.InventoryStatus = cb_inventoryStatusUpdate.Text;

            if (product.update()){
                MessageBox.Show("Product Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateDataGrid();
                this.Close();
            }
          
        }

        private void updateDataGrid()
        {
            data.CurrentRow.Cells["product_ID"].Value = product.Product_ID;
            data.CurrentRow.Cells["productCode"].Value = Int32.Parse(product.ProductCode);
            data.CurrentRow.Cells["ProductName"].Value = product.ProductName;
            data.CurrentRow.Cells["Size"].Value = product.Size;
            data.CurrentRow.Cells["productCategory"].Value = product.Category;
            data.CurrentRow.Cells["productStock"].Value = product.ProductQTY;
            data.CurrentRow.Cells["minToReorder"].Value = product.MinToReorder;
            data.CurrentRow.Cells["productLocation"].Value = product.ProdLocation;
        }

        private void loadData()
        {
            
            int id = (int)data.CurrentRow.Cells["product_ID"].Value;
            Controllers.ProductDAO_ productHelper = new Controllers.ProductDAO_();
            product = new Models.Product_();
            product = productHelper.get(id);
            string width = Helper.StringHelper.prepSize(product.Size)[0];
            string height = Helper.StringHelper.prepSize(product.Size)[1];
         
            // load to view
            tb_nameUpdate.Text = product.ProductName;
            tb_lotNumberUpdate.Text = product.ProductLotNum;
            tb_sizeWidthUpdate.Text = width;
            tb_sizeHeightUpdate.Text = height;
            tb_locationUpdate.Text = product.ProdLocation;
            cb_codeUpdate.Text = product.ProductCode;
            cb_categoryUpdate.Text = product.Category;
            tb_qtyUpdate.Text = product.ProductQTY.ToString();
            cb_typeUpdate.Text = product.ProductType;
            cb_productStatusUpdate.Text = product.ProductStatus;
            tb_minToOrderUpdate.Text = product.MinToReorder.ToString();
            cb_inventoryStatusUpdate.Text = product.InventoryStatus.ToString();



        }
        private void ClearTextBoxes(Control control)
        {
            foreach (var c in control.Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = String.Empty;
                if (c is ComboBox) ((ComboBox)c).SelectedItem = null;
            }
        }

    }
}
