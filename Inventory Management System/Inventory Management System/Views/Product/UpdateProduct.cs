using MySqlX.XDevAPI.Relational;

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadData()
        {
            int productCode = 0;
            string lotNumber = "";
            string productName = data.CurrentRow.Cells["ProductName"].Value.ToString();
            string width = "";
            string hight = "";
            string location = "";
            string category = "";
            string qty = "";
            int minToReorder = 0;

            // load to view
            tb_nameUpdate.Text = productName;



        }
    }
}
