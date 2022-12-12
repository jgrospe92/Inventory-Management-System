namespace Inventory_Management_System.Views.Home
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.productsDataGrid = new System.Windows.Forms.DataGridView();
            this.product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minToReorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearHomeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.recordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(43, 37);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Search by Code / Name";
            this.searchTextBox.Size = new System.Drawing.Size(236, 31);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // applyButton
            // 
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyButton.Location = new System.Drawing.Point(301, 33);
            this.applyButton.Name = "applyButton";
            this.applyButton.Padding = new System.Windows.Forms.Padding(5);
            this.applyButton.Size = new System.Drawing.Size(94, 37);
            this.applyButton.TabIndex = 6;
            this.applyButton.Text = "APPLY";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // productsDataGrid
            // 
            this.productsDataGrid.AllowUserToAddRows = false;
            this.productsDataGrid.AllowUserToDeleteRows = false;
            this.productsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productsDataGrid.ColumnHeadersHeight = 30;
            this.productsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_ID,
            this.productCode,
            this.ProductName,
            this.Size,
            this.productCategory,
            this.productStock,
            this.minToReorder,
            this.productLocation,
            this.deleteProduct,
            this.productEdit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.productsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsDataGrid.EnableHeadersVisualStyles = false;
            this.productsDataGrid.Location = new System.Drawing.Point(0, 80);
            this.productsDataGrid.Name = "productsDataGrid";
            this.productsDataGrid.ReadOnly = true;
            this.productsDataGrid.RowHeadersVisible = false;
            this.productsDataGrid.RowHeadersWidth = 50;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.productsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.productsDataGrid.RowTemplate.Height = 29;
            this.productsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGrid.Size = new System.Drawing.Size(998, 491);
            this.productsDataGrid.TabIndex = 7;
            this.productsDataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGrid_CellContentClick);
            // 
            // product_ID
            // 
            this.product_ID.HeaderText = "id";
            this.product_ID.MinimumWidth = 6;
            this.product_ID.Name = "product_ID";
            this.product_ID.ReadOnly = true;
            this.product_ID.Visible = false;
            this.product_ID.Width = 125;
            // 
            // productCode
            // 
            this.productCode.HeaderText = "Code";
            this.productCode.MinimumWidth = 6;
            this.productCode.Name = "productCode";
            this.productCode.ReadOnly = true;
            this.productCode.Width = 111;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 110;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.MinimumWidth = 6;
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 111;
            // 
            // productCategory
            // 
            this.productCategory.HeaderText = "Category";
            this.productCategory.MinimumWidth = 6;
            this.productCategory.Name = "productCategory";
            this.productCategory.ReadOnly = true;
            this.productCategory.Width = 110;
            // 
            // productStock
            // 
            this.productStock.HeaderText = "InStock";
            this.productStock.MinimumWidth = 6;
            this.productStock.Name = "productStock";
            this.productStock.ReadOnly = true;
            this.productStock.Width = 111;
            // 
            // minToReorder
            // 
            this.minToReorder.HeaderText = "Minimum";
            this.minToReorder.MinimumWidth = 6;
            this.minToReorder.Name = "minToReorder";
            this.minToReorder.ReadOnly = true;
            this.minToReorder.Width = 110;
            // 
            // productLocation
            // 
            this.productLocation.HeaderText = "Location";
            this.productLocation.MinimumWidth = 6;
            this.productLocation.Name = "productLocation";
            this.productLocation.ReadOnly = true;
            this.productLocation.Width = 111;
            // 
            // deleteProduct
            // 
            this.deleteProduct.HeaderText = "Delete";
            this.deleteProduct.MinimumWidth = 6;
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.ReadOnly = true;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseColumnTextForButtonValue = true;
            this.deleteProduct.Width = 110;
            // 
            // productEdit
            // 
            this.productEdit.HeaderText = "Edit";
            this.productEdit.MinimumWidth = 6;
            this.productEdit.Name = "productEdit";
            this.productEdit.ReadOnly = true;
            this.productEdit.Text = "Update";
            this.productEdit.UseColumnTextForButtonValue = true;
            this.productEdit.Width = 111;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clearHomeButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.applyButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 80);
            this.panel1.TabIndex = 8;
            // 
            // clearHomeButton
            // 
            this.clearHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearHomeButton.Location = new System.Drawing.Point(428, 33);
            this.clearHomeButton.Name = "clearHomeButton";
            this.clearHomeButton.Padding = new System.Windows.Forms.Padding(5);
            this.clearHomeButton.Size = new System.Drawing.Size(94, 37);
            this.clearHomeButton.TabIndex = 7;
            this.clearHomeButton.Text = "CLEAR";
            this.clearHomeButton.UseVisualStyleBackColor = true;
            this.clearHomeButton.Click += new System.EventHandler(this.clearHomeButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.recordLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 571);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 22);
            this.panel2.TabIndex = 9;
            // 
            // recordLabel
            // 
            this.recordLabel.AutoSize = true;
            this.recordLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.recordLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recordLabel.Location = new System.Drawing.Point(0, 0);
            this.recordLabel.Name = "recordLabel";
            this.recordLabel.Size = new System.Drawing.Size(81, 20);
            this.recordLabel.TabIndex = 0;
            this.recordLabel.Text = "Record: ";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 593);
            this.Controls.Add(this.productsDataGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1016, 640);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox searchTextBox;
        private Button applyButton;
        private DataGridView productsDataGrid;
        private Panel panel1;
        private Panel panel2;
        private Label recordLabel;
        private Button clearHomeButton;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn productCode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn productCategory;
        private DataGridViewTextBoxColumn productStock;
        private DataGridViewTextBoxColumn minToReorder;
        private DataGridViewTextBoxColumn productLocation;
        private DataGridViewButtonColumn deleteProduct;
        private DataGridViewButtonColumn productEdit;
        private DataGridViewTextBoxColumn product_ID;
    }
}