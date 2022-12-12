namespace Inventory_Management_System.Views.Product
{
    partial class UpdateProduct
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
            this.cb_inventoryStatusUpdate = new System.Windows.Forms.ComboBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.cb_productStatusUpdate = new System.Windows.Forms.ComboBox();
            this.cb_typeUpdate = new System.Windows.Forms.ComboBox();
            this.productStatusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_categoryUpdate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_sizeHeightUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.minToOrderLabel = new System.Windows.Forms.Label();
            this.tb_minToOrderUpdate = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.tb_locationUpdate = new System.Windows.Forms.TextBox();
            this.stockDetailLabel = new System.Windows.Forms.Label();
            this.tb_qtyUpdate = new System.Windows.Forms.TextBox();
            this.categoryDetailLabel = new System.Windows.Forms.Label();
            this.codeDetailLabel = new System.Windows.Forms.Label();
            this.cb_codeUpdate = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.tb_sizeWidthUpdate = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tb_nameUpdate = new System.Windows.Forms.TextBox();
            this.lotNumberLabel = new System.Windows.Forms.Label();
            this.tb_lotNumberUpdate = new System.Windows.Forms.TextBox();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_inventoryStatusUpdate
            // 
            this.cb_inventoryStatusUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_inventoryStatusUpdate.FormattingEnabled = true;
            this.cb_inventoryStatusUpdate.Items.AddRange(new object[] {
            "IN STOCK",
            "OUT OF STOCK"});
            this.cb_inventoryStatusUpdate.Location = new System.Drawing.Point(691, 261);
            this.cb_inventoryStatusUpdate.Name = "cb_inventoryStatusUpdate";
            this.cb_inventoryStatusUpdate.Size = new System.Drawing.Size(277, 28);
            this.cb_inventoryStatusUpdate.TabIndex = 113;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inventoryLabel.Location = new System.Drawing.Point(691, 221);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(169, 28);
            this.inventoryLabel.TabIndex = 112;
            this.inventoryLabel.Text = "Inventory Status";
            // 
            // cb_productStatusUpdate
            // 
            this.cb_productStatusUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_productStatusUpdate.FormattingEnabled = true;
            this.cb_productStatusUpdate.Items.AddRange(new object[] {
            "ACTIVE ",
            "DISCONTINUED"});
            this.cb_productStatusUpdate.Location = new System.Drawing.Point(691, 75);
            this.cb_productStatusUpdate.Name = "cb_productStatusUpdate";
            this.cb_productStatusUpdate.Size = new System.Drawing.Size(277, 28);
            this.cb_productStatusUpdate.TabIndex = 111;
            // 
            // cb_typeUpdate
            // 
            this.cb_typeUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typeUpdate.FormattingEnabled = true;
            this.cb_typeUpdate.Items.AddRange(new object[] {
            "PRIVATE",
            "RH",
            "OTHER"});
            this.cb_typeUpdate.Location = new System.Drawing.Point(357, 358);
            this.cb_typeUpdate.Name = "cb_typeUpdate";
            this.cb_typeUpdate.Size = new System.Drawing.Size(277, 28);
            this.cb_typeUpdate.TabIndex = 110;
            // 
            // productStatusLabel
            // 
            this.productStatusLabel.AutoSize = true;
            this.productStatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productStatusLabel.Location = new System.Drawing.Point(691, 35);
            this.productStatusLabel.Name = "productStatusLabel";
            this.productStatusLabel.Size = new System.Drawing.Size(151, 28);
            this.productStatusLabel.TabIndex = 109;
            this.productStatusLabel.Text = "Product Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(357, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 108;
            this.label2.Text = "Brand";
            // 
            // cb_categoryUpdate
            // 
            this.cb_categoryUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoryUpdate.FormattingEnabled = true;
            this.cb_categoryUpdate.Items.AddRange(new object[] {
            "PLAIN",
            "COLORED",
            "SAUCE",
            "GRAVY",
            "SOUP",
            "BOUILLON",
            "SEASONING",
            "MARINADE",
            "OTHER"});
            this.cb_categoryUpdate.Location = new System.Drawing.Point(357, 163);
            this.cb_categoryUpdate.Name = "cb_categoryUpdate";
            this.cb_categoryUpdate.Size = new System.Drawing.Size(277, 28);
            this.cb_categoryUpdate.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(97, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 28);
            this.label1.TabIndex = 106;
            this.label1.Text = "X";
            // 
            // tb_sizeHeightUpdate
            // 
            this.tb_sizeHeightUpdate.Location = new System.Drawing.Point(128, 261);
            this.tb_sizeHeightUpdate.Name = "tb_sizeHeightUpdate";
            this.tb_sizeHeightUpdate.PlaceholderText = "height";
            this.tb_sizeHeightUpdate.Size = new System.Drawing.Size(68, 27);
            this.tb_sizeHeightUpdate.TabIndex = 105;
            this.tb_sizeHeightUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_sizeHeigthUpdate_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(832, 496);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 52);
            this.btnUpdate.TabIndex = 104;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // minToOrderLabel
            // 
            this.minToOrderLabel.AutoSize = true;
            this.minToOrderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minToOrderLabel.Location = new System.Drawing.Point(691, 124);
            this.minToOrderLabel.Name = "minToOrderLabel";
            this.minToOrderLabel.Size = new System.Drawing.Size(212, 28);
            this.minToOrderLabel.TabIndex = 103;
            this.minToOrderLabel.Text = "Minimum To Reorder";
            // 
            // tb_minToOrderUpdate
            // 
            this.tb_minToOrderUpdate.Location = new System.Drawing.Point(691, 164);
            this.tb_minToOrderUpdate.Name = "tb_minToOrderUpdate";
            this.tb_minToOrderUpdate.PlaceholderText = "Enter minium amount to reorder";
            this.tb_minToOrderUpdate.Size = new System.Drawing.Size(277, 27);
            this.tb_minToOrderUpdate.TabIndex = 102;
            this.tb_minToOrderUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_minToOrderUpdate_KeyPress);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.locationLabel.Location = new System.Drawing.Point(29, 318);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(93, 28);
            this.locationLabel.TabIndex = 101;
            this.locationLabel.Text = "Location";
            // 
            // tb_locationUpdate
            // 
            this.tb_locationUpdate.Location = new System.Drawing.Point(29, 358);
            this.tb_locationUpdate.Name = "tb_locationUpdate";
            this.tb_locationUpdate.PlaceholderText = "Enter Item location";
            this.tb_locationUpdate.Size = new System.Drawing.Size(277, 27);
            this.tb_locationUpdate.TabIndex = 100;
            // 
            // stockDetailLabel
            // 
            this.stockDetailLabel.AutoSize = true;
            this.stockDetailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stockDetailLabel.Location = new System.Drawing.Point(357, 221);
            this.stockDetailLabel.Name = "stockDetailLabel";
            this.stockDetailLabel.Size = new System.Drawing.Size(64, 28);
            this.stockDetailLabel.TabIndex = 99;
            this.stockDetailLabel.Text = "Stock";
            // 
            // tb_qtyUpdate
            // 
            this.tb_qtyUpdate.Location = new System.Drawing.Point(357, 261);
            this.tb_qtyUpdate.Name = "tb_qtyUpdate";
            this.tb_qtyUpdate.PlaceholderText = "Enter product quantity";
            this.tb_qtyUpdate.Size = new System.Drawing.Size(277, 27);
            this.tb_qtyUpdate.TabIndex = 98;
            this.tb_qtyUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_qtyUpdate_KeyPress);
            // 
            // categoryDetailLabel
            // 
            this.categoryDetailLabel.AutoSize = true;
            this.categoryDetailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryDetailLabel.Location = new System.Drawing.Point(357, 124);
            this.categoryDetailLabel.Name = "categoryDetailLabel";
            this.categoryDetailLabel.Size = new System.Drawing.Size(98, 28);
            this.categoryDetailLabel.TabIndex = 97;
            this.categoryDetailLabel.Text = "Category";
            // 
            // codeDetailLabel
            // 
            this.codeDetailLabel.AutoSize = true;
            this.codeDetailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codeDetailLabel.Location = new System.Drawing.Point(357, 35);
            this.codeDetailLabel.Name = "codeDetailLabel";
            this.codeDetailLabel.Size = new System.Drawing.Size(59, 28);
            this.codeDetailLabel.TabIndex = 96;
            this.codeDetailLabel.Text = "Code";
            // 
            // cb_codeUpdate
            // 
            this.cb_codeUpdate.Location = new System.Drawing.Point(357, 75);
            this.cb_codeUpdate.Name = "cb_codeUpdate";
            this.cb_codeUpdate.PlaceholderText = "Enter item code / max 7 digits";
            this.cb_codeUpdate.Size = new System.Drawing.Size(277, 27);
            this.cb_codeUpdate.TabIndex = 95;
            this.cb_codeUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_codeUpdate_KeyPress);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sizeLabel.Location = new System.Drawing.Point(29, 221);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(50, 28);
            this.sizeLabel.TabIndex = 94;
            this.sizeLabel.Text = "Size";
            // 
            // tb_sizeWidthUpdate
            // 
            this.tb_sizeWidthUpdate.Location = new System.Drawing.Point(29, 261);
            this.tb_sizeWidthUpdate.Name = "tb_sizeWidthUpdate";
            this.tb_sizeWidthUpdate.PlaceholderText = "width";
            this.tb_sizeWidthUpdate.Size = new System.Drawing.Size(68, 27);
            this.tb_sizeWidthUpdate.TabIndex = 93;
            this.tb_sizeWidthUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_sizeWidthUpdate_KeyPress);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(29, 124);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 28);
            this.nameLabel.TabIndex = 92;
            this.nameLabel.Text = "Name";
            // 
            // tb_nameUpdate
            // 
            this.tb_nameUpdate.Location = new System.Drawing.Point(29, 164);
            this.tb_nameUpdate.Name = "tb_nameUpdate";
            this.tb_nameUpdate.PlaceholderText = "Enter Name";
            this.tb_nameUpdate.Size = new System.Drawing.Size(277, 27);
            this.tb_nameUpdate.TabIndex = 91;
            // 
            // lotNumberLabel
            // 
            this.lotNumberLabel.AutoSize = true;
            this.lotNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lotNumberLabel.Location = new System.Drawing.Point(29, 35);
            this.lotNumberLabel.Name = "lotNumberLabel";
            this.lotNumberLabel.Size = new System.Drawing.Size(125, 28);
            this.lotNumberLabel.TabIndex = 90;
            this.lotNumberLabel.Text = "Lot Number";
            // 
            // tb_lotNumberUpdate
            // 
            this.tb_lotNumberUpdate.Location = new System.Drawing.Point(29, 75);
            this.tb_lotNumberUpdate.Name = "tb_lotNumberUpdate";
            this.tb_lotNumberUpdate.PlaceholderText = "Enter Lot Number / max 7 digits";
            this.tb_lotNumberUpdate.Size = new System.Drawing.Size(277, 27);
            this.tb_lotNumberUpdate.TabIndex = 89;
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelUpdate.ForeColor = System.Drawing.Color.White;
            this.btnCancelUpdate.Location = new System.Drawing.Point(679, 496);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(136, 52);
            this.btnCancelUpdate.TabIndex = 118;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = false;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 593);
            this.Controls.Add(this.btnCancelUpdate);
            this.Controls.Add(this.cb_inventoryStatusUpdate);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.cb_productStatusUpdate);
            this.Controls.Add(this.cb_typeUpdate);
            this.Controls.Add(this.productStatusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_categoryUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_sizeHeightUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.minToOrderLabel);
            this.Controls.Add(this.tb_minToOrderUpdate);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.tb_locationUpdate);
            this.Controls.Add(this.stockDetailLabel);
            this.Controls.Add(this.tb_qtyUpdate);
            this.Controls.Add(this.categoryDetailLabel);
            this.Controls.Add(this.codeDetailLabel);
            this.Controls.Add(this.cb_codeUpdate);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.tb_sizeWidthUpdate);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.tb_nameUpdate);
            this.Controls.Add(this.lotNumberLabel);
            this.Controls.Add(this.tb_lotNumberUpdate);
            this.Name = "UpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cb_inventoryStatusUpdate;
        private Label inventoryLabel;
        private ComboBox cb_productStatusUpdate;
        private ComboBox cb_typeUpdate;
        private Label productStatusLabel;
        private Label label2;
        private ComboBox cb_categoryUpdate;
        private Label label1;
        private TextBox tb_sizeHeightUpdate;
        private Button btnUpdate;
        private Label minToOrderLabel;
        private TextBox tb_minToOrderUpdate;
        private Label locationLabel;
        private TextBox tb_locationUpdate;
        private Label stockDetailLabel;
        private TextBox tb_qtyUpdate;
        private Label categoryDetailLabel;
        private Label codeDetailLabel;
        private TextBox cb_codeUpdate;
        private Label sizeLabel;
        private TextBox tb_sizeWidthUpdate;
        private Label nameLabel;
        private TextBox tb_nameUpdate;
        private Label lotNumberLabel;
        private TextBox tb_lotNumberUpdate;
        private Button btnCancelUpdate;
    }
}