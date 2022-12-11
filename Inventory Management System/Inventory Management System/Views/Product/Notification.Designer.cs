namespace Inventory_Management_System.Views.Product
{
    partial class Notification
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
            this.notificationLabel = new System.Windows.Forms.Label();
            this.noLowStockLabel = new System.Windows.Forms.Panel();
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
            this.noLowStockLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // notificationLabel
            // 
            this.notificationLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notificationLabel.Location = new System.Drawing.Point(381, 9);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(212, 42);
            this.notificationLabel.TabIndex = 14;
            this.notificationLabel.Text = "No Low Stock!";
            this.notificationLabel.Visible = false;
            // 
            // noLowStockLabel
            // 
            this.noLowStockLabel.Controls.Add(this.notificationLabel);
            this.noLowStockLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.noLowStockLabel.Location = new System.Drawing.Point(0, 0);
            this.noLowStockLabel.Name = "noLowStockLabel";
            this.noLowStockLabel.Size = new System.Drawing.Size(998, 65);
            this.noLowStockLabel.TabIndex = 15;
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
            this.productsDataGrid.Location = new System.Drawing.Point(0, 65);
            this.productsDataGrid.Name = "productsDataGrid";
            this.productsDataGrid.ReadOnly = true;
            this.productsDataGrid.RowHeadersVisible = false;
            this.productsDataGrid.RowHeadersWidth = 50;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.productsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.productsDataGrid.RowTemplate.Height = 29;
            this.productsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGrid.Size = new System.Drawing.Size(998, 479);
            this.productsDataGrid.TabIndex = 16;
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
            this.productCode.Width = 142;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 142;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.MinimumWidth = 6;
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 142;
            // 
            // productCategory
            // 
            this.productCategory.HeaderText = "Category";
            this.productCategory.MinimumWidth = 6;
            this.productCategory.Name = "productCategory";
            this.productCategory.ReadOnly = true;
            this.productCategory.Width = 143;
            // 
            // productStock
            // 
            this.productStock.HeaderText = "InStock";
            this.productStock.MinimumWidth = 6;
            this.productStock.Name = "productStock";
            this.productStock.ReadOnly = true;
            this.productStock.Width = 142;
            // 
            // minToReorder
            // 
            this.minToReorder.HeaderText = "Minimum";
            this.minToReorder.MinimumWidth = 6;
            this.minToReorder.Name = "minToReorder";
            this.minToReorder.ReadOnly = true;
            this.minToReorder.Width = 142;
            // 
            // productLocation
            // 
            this.productLocation.HeaderText = "Location";
            this.productLocation.MinimumWidth = 6;
            this.productLocation.Name = "productLocation";
            this.productLocation.ReadOnly = true;
            this.productLocation.Width = 160;
            // 
            // deleteProduct
            // 
            this.deleteProduct.HeaderText = "Delete";
            this.deleteProduct.MinimumWidth = 6;
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.ReadOnly = true;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseColumnTextForButtonValue = true;
            this.deleteProduct.Visible = false;
            this.deleteProduct.Width = 125;
            // 
            // productEdit
            // 
            this.productEdit.HeaderText = "Edit";
            this.productEdit.MinimumWidth = 6;
            this.productEdit.Name = "productEdit";
            this.productEdit.ReadOnly = true;
            this.productEdit.Text = "Update";
            this.productEdit.UseColumnTextForButtonValue = true;
            this.productEdit.Visible = false;
            this.productEdit.Width = 125;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 544);
            this.Controls.Add(this.productsDataGrid);
            this.Controls.Add(this.noLowStockLabel);
            this.MaximumSize = new System.Drawing.Size(1016, 640);
            this.Name = "Notification";
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.Notification_Load);
            this.noLowStockLabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label notificationLabel;
        private Panel noLowStockLabel;
        private DataGridView productsDataGrid;
        private DataGridViewTextBoxColumn product_ID;
        private DataGridViewTextBoxColumn productCode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn productCategory;
        private DataGridViewTextBoxColumn productStock;
        private DataGridViewTextBoxColumn minToReorder;
        private DataGridViewTextBoxColumn productLocation;
        private DataGridViewButtonColumn deleteProduct;
        private DataGridViewButtonColumn productEdit;
    }
}