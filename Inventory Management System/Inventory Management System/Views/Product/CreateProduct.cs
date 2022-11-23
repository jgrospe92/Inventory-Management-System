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
    public partial class CreateProduct : Form
    {
        /* 
            This is what i eventually would need to do. 

            Product product = new Product(lotNumberDetailTextBox.Text, );
            List<Product> myList = new List<Product>();

            myList.Add(product);
            myList.get(0).getLocation;
        */

        List<string> myArr = new List<string>();

        public CreateProduct()
        {
            InitializeComponent();

        }

        private void createProductBtn_Click(object sender, EventArgs e)
        {
            myArr.Add(lotNumberDetailTextBox.Text);
            myArr.Add(nameDetailTextBox.Text);
            myArr.Add(tb_sizeWidth.Text);
            myArr.Add(tb_sizeHeight.Text);
            myArr.Add(locationDetailTextBox.Text);
            myArr.Add(notifyAtDetailTextBox.Text);
            myArr.Add(codeDetailTextBox.Text);
            myArr.Add(cb_category.Text);
            myArr.Add(stockDetailTextBox.Text);
            myArr.Add(brandDetailTextBox.Text);

            for (int i = 0; i < myArr.Count; i++)
            {
                MessageBox.Show(myArr[i]);
       
            }
            myArr.Clear();
            }
        }
}
