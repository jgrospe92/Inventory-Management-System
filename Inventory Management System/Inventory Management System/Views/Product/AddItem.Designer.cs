namespace Inventory_Management_System.Views.Product
{
    partial class AddItem
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
            this.cb_categoryAdd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_sizeHeightAdd = new System.Windows.Forms.TextBox();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.minToOrderLabel = new System.Windows.Forms.Label();
            this.tb_minToOrderAdd = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.tb_locationAdd = new System.Windows.Forms.TextBox();
            this.stockDetailLabel = new System.Windows.Forms.Label();
            this.tb_qtyAdd = new System.Windows.Forms.TextBox();
            this.categoryDetailLabel = new System.Windows.Forms.Label();
            this.codeDetailLabel = new System.Windows.Forms.Label();
            this.cb_codeAdd = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.tb_sizeWidthAdd = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tb_nameAdd = new System.Windows.Forms.TextBox();
            this.lotNumberLabel = new System.Windows.Forms.Label();
            this.tb_lotNumberAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productStatusLabel = new System.Windows.Forms.Label();
            this.cb_typeAdd = new System.Windows.Forms.ComboBox();
            this.cb_productStatusAdd = new System.Windows.Forms.ComboBox();
            this.cb_inventoryStatusAdd = new System.Windows.Forms.ComboBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.dtp_DateAddedAdd = new System.Windows.Forms.DateTimePicker();
            this.dtp_DateUpdatedAdd = new System.Windows.Forms.DateTimePicker();
            this.dateAddedLabel = new System.Windows.Forms.Label();
            this.updatedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_categoryAdd
            // 
            this.cb_categoryAdd.FormattingEnabled = true;
            this.cb_categoryAdd.Items.AddRange(new object[] {
            "PLAIN",
            "COLORED",
            "SAUCE",
            "GRAVY",
            "SOUP",
            "BOUILLON",
            "SEASONING",
            "MARINADE",
            "OTHER"});
            this.cb_categoryAdd.Location = new System.Drawing.Point(356, 160);
            this.cb_categoryAdd.Name = "cb_categoryAdd";
            this.cb_categoryAdd.Size = new System.Drawing.Size(277, 28);
            this.cb_categoryAdd.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(96, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "X";
            // 
            // tb_sizeHeightAdd
            // 
            this.tb_sizeHeightAdd.Location = new System.Drawing.Point(127, 258);
            this.tb_sizeHeightAdd.Name = "tb_sizeHeightAdd";
            this.tb_sizeHeightAdd.PlaceholderText = "height";
            this.tb_sizeHeightAdd.Size = new System.Drawing.Size(68, 27);
            this.tb_sizeHeightAdd.TabIndex = 44;
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelAdd.ForeColor = System.Drawing.Color.White;
            this.btnCancelAdd.Location = new System.Drawing.Point(677, 427);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(136, 52);
            this.btnCancelAdd.TabIndex = 43;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(831, 427);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 52);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Create";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // minToOrderLabel
            // 
            this.minToOrderLabel.AutoSize = true;
            this.minToOrderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minToOrderLabel.Location = new System.Drawing.Point(28, 412);
            this.minToOrderLabel.Name = "minToOrderLabel";
            this.minToOrderLabel.Size = new System.Drawing.Size(212, 28);
            this.minToOrderLabel.TabIndex = 39;
            this.minToOrderLabel.Text = "Minimum To Reorder";
            // 
            // tb_minToOrderAdd
            // 
            this.tb_minToOrderAdd.Location = new System.Drawing.Point(28, 452);
            this.tb_minToOrderAdd.Name = "tb_minToOrderAdd";
            this.tb_minToOrderAdd.PlaceholderText = "Enter minium amount to reorder";
            this.tb_minToOrderAdd.Size = new System.Drawing.Size(277, 27);
            this.tb_minToOrderAdd.TabIndex = 38;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.locationLabel.Location = new System.Drawing.Point(28, 315);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(93, 28);
            this.locationLabel.TabIndex = 37;
            this.locationLabel.Text = "Location";
            // 
            // tb_locationAdd
            // 
            this.tb_locationAdd.Location = new System.Drawing.Point(28, 355);
            this.tb_locationAdd.Name = "tb_locationAdd";
            this.tb_locationAdd.PlaceholderText = "Enter Item location";
            this.tb_locationAdd.Size = new System.Drawing.Size(277, 27);
            this.tb_locationAdd.TabIndex = 36;
            // 
            // stockDetailLabel
            // 
            this.stockDetailLabel.AutoSize = true;
            this.stockDetailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stockDetailLabel.Location = new System.Drawing.Point(356, 218);
            this.stockDetailLabel.Name = "stockDetailLabel";
            this.stockDetailLabel.Size = new System.Drawing.Size(64, 28);
            this.stockDetailLabel.TabIndex = 35;
            this.stockDetailLabel.Text = "Stock";
            // 
            // tb_qtyAdd
            // 
            this.tb_qtyAdd.Location = new System.Drawing.Point(356, 258);
            this.tb_qtyAdd.Name = "tb_qtyAdd";
            this.tb_qtyAdd.PlaceholderText = "Enter product quantity";
            this.tb_qtyAdd.Size = new System.Drawing.Size(277, 27);
            this.tb_qtyAdd.TabIndex = 34;
            // 
            // categoryDetailLabel
            // 
            this.categoryDetailLabel.AutoSize = true;
            this.categoryDetailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryDetailLabel.Location = new System.Drawing.Point(356, 121);
            this.categoryDetailLabel.Name = "categoryDetailLabel";
            this.categoryDetailLabel.Size = new System.Drawing.Size(98, 28);
            this.categoryDetailLabel.TabIndex = 33;
            this.categoryDetailLabel.Text = "Category";
            // 
            // codeDetailLabel
            // 
            this.codeDetailLabel.AutoSize = true;
            this.codeDetailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codeDetailLabel.Location = new System.Drawing.Point(356, 32);
            this.codeDetailLabel.Name = "codeDetailLabel";
            this.codeDetailLabel.Size = new System.Drawing.Size(59, 28);
            this.codeDetailLabel.TabIndex = 32;
            this.codeDetailLabel.Text = "Code";
            // 
            // cb_codeAdd
            // 
            this.cb_codeAdd.Location = new System.Drawing.Point(356, 72);
            this.cb_codeAdd.Name = "cb_codeAdd";
            this.cb_codeAdd.PlaceholderText = "Enter item code";
            this.cb_codeAdd.Size = new System.Drawing.Size(277, 27);
            this.cb_codeAdd.TabIndex = 31;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sizeLabel.Location = new System.Drawing.Point(28, 218);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(50, 28);
            this.sizeLabel.TabIndex = 30;
            this.sizeLabel.Text = "Size";
            // 
            // tb_sizeWidthAdd
            // 
            this.tb_sizeWidthAdd.Location = new System.Drawing.Point(28, 258);
            this.tb_sizeWidthAdd.Name = "tb_sizeWidthAdd";
            this.tb_sizeWidthAdd.PlaceholderText = "width";
            this.tb_sizeWidthAdd.Size = new System.Drawing.Size(68, 27);
            this.tb_sizeWidthAdd.TabIndex = 29;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(28, 121);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 28);
            this.nameLabel.TabIndex = 28;
            this.nameLabel.Text = "Name";
            // 
            // tb_nameAdd
            // 
            this.tb_nameAdd.Location = new System.Drawing.Point(28, 161);
            this.tb_nameAdd.Name = "tb_nameAdd";
            this.tb_nameAdd.PlaceholderText = "Enter Name";
            this.tb_nameAdd.Size = new System.Drawing.Size(277, 27);
            this.tb_nameAdd.TabIndex = 27;
            // 
            // lotNumberLabel
            // 
            this.lotNumberLabel.AutoSize = true;
            this.lotNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lotNumberLabel.Location = new System.Drawing.Point(28, 32);
            this.lotNumberLabel.Name = "lotNumberLabel";
            this.lotNumberLabel.Size = new System.Drawing.Size(125, 28);
            this.lotNumberLabel.TabIndex = 26;
            this.lotNumberLabel.Text = "Lot Number";
            // 
            // tb_lotNumberAdd
            // 
            this.tb_lotNumberAdd.Location = new System.Drawing.Point(28, 72);
            this.tb_lotNumberAdd.Name = "tb_lotNumberAdd";
            this.tb_lotNumberAdd.PlaceholderText = "Enter Lot Number";
            this.tb_lotNumberAdd.Size = new System.Drawing.Size(277, 27);
            this.tb_lotNumberAdd.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(356, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 48;
            this.label2.Text = "Brand";
            // 
            // productStatusLabel
            // 
            this.productStatusLabel.AutoSize = true;
            this.productStatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productStatusLabel.Location = new System.Drawing.Point(690, 32);
            this.productStatusLabel.Name = "productStatusLabel";
            this.productStatusLabel.Size = new System.Drawing.Size(151, 28);
            this.productStatusLabel.TabIndex = 50;
            this.productStatusLabel.Text = "Product Status";
            // 
            // cb_typeAdd
            // 
            this.cb_typeAdd.FormattingEnabled = true;
            this.cb_typeAdd.Items.AddRange(new object[] {
            "PRIVATE",
            "RH",
            "OTHER"});
            this.cb_typeAdd.Location = new System.Drawing.Point(356, 355);
            this.cb_typeAdd.Name = "cb_typeAdd";
            this.cb_typeAdd.Size = new System.Drawing.Size(277, 28);
            this.cb_typeAdd.TabIndex = 51;
            // 
            // cb_productStatusAdd
            // 
            this.cb_productStatusAdd.FormattingEnabled = true;
            this.cb_productStatusAdd.Items.AddRange(new object[] {
            "ACTIVE ",
            "DISCONTINUED"});
            this.cb_productStatusAdd.Location = new System.Drawing.Point(690, 72);
            this.cb_productStatusAdd.Name = "cb_productStatusAdd";
            this.cb_productStatusAdd.Size = new System.Drawing.Size(277, 28);
            this.cb_productStatusAdd.TabIndex = 52;
            // 
            // cb_inventoryStatusAdd
            // 
            this.cb_inventoryStatusAdd.FormattingEnabled = true;
            this.cb_inventoryStatusAdd.Items.AddRange(new object[] {
            "IN STOCK",
            "OUT OF STOCK"});
            this.cb_inventoryStatusAdd.Location = new System.Drawing.Point(690, 355);
            this.cb_inventoryStatusAdd.Name = "cb_inventoryStatusAdd";
            this.cb_inventoryStatusAdd.Size = new System.Drawing.Size(277, 28);
            this.cb_inventoryStatusAdd.TabIndex = 54;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inventoryLabel.Location = new System.Drawing.Point(690, 315);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(169, 28);
            this.inventoryLabel.TabIndex = 53;
            this.inventoryLabel.Text = "Inventory Status";
            // 
            // dtp_DateAddedAdd
            // 
            this.dtp_DateAddedAdd.Location = new System.Drawing.Point(690, 158);
            this.dtp_DateAddedAdd.Name = "dtp_DateAddedAdd";
            this.dtp_DateAddedAdd.Size = new System.Drawing.Size(250, 27);
            this.dtp_DateAddedAdd.TabIndex = 55;
            // 
            // dtp_DateUpdatedAdd
            // 
            this.dtp_DateUpdatedAdd.Location = new System.Drawing.Point(690, 256);
            this.dtp_DateUpdatedAdd.Name = "dtp_DateUpdatedAdd";
            this.dtp_DateUpdatedAdd.Size = new System.Drawing.Size(250, 27);
            this.dtp_DateUpdatedAdd.TabIndex = 56;
            // 
            // dateAddedLabel
            // 
            this.dateAddedLabel.AutoSize = true;
            this.dateAddedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateAddedLabel.Location = new System.Drawing.Point(690, 121);
            this.dateAddedLabel.Name = "dateAddedLabel";
            this.dateAddedLabel.Size = new System.Drawing.Size(124, 28);
            this.dateAddedLabel.TabIndex = 57;
            this.dateAddedLabel.Text = "Date Added";
            // 
            // updatedLabel
            // 
            this.updatedLabel.AutoSize = true;
            this.updatedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updatedLabel.Location = new System.Drawing.Point(690, 218);
            this.updatedLabel.Name = "updatedLabel";
            this.updatedLabel.Size = new System.Drawing.Size(136, 28);
            this.updatedLabel.TabIndex = 58;
            this.updatedLabel.Text = "Last Updated";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 519);
            this.Controls.Add(this.updatedLabel);
            this.Controls.Add(this.dateAddedLabel);
            this.Controls.Add(this.dtp_DateUpdatedAdd);
            this.Controls.Add(this.dtp_DateAddedAdd);
            this.Controls.Add(this.cb_inventoryStatusAdd);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.cb_productStatusAdd);
            this.Controls.Add(this.cb_typeAdd);
            this.Controls.Add(this.productStatusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_categoryAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_sizeHeightAdd);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.minToOrderLabel);
            this.Controls.Add(this.tb_minToOrderAdd);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.tb_locationAdd);
            this.Controls.Add(this.stockDetailLabel);
            this.Controls.Add(this.tb_qtyAdd);
            this.Controls.Add(this.categoryDetailLabel);
            this.Controls.Add(this.codeDetailLabel);
            this.Controls.Add(this.cb_codeAdd);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.tb_sizeWidthAdd);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.tb_nameAdd);
            this.Controls.Add(this.lotNumberLabel);
            this.Controls.Add(this.tb_lotNumberAdd);
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cb_categoryAdd;
        private Label label1;
        private TextBox tb_sizeHeightAdd;
        private Button btnCancelAdd;
        private Button btnAdd;
        private Label minToOrderLabel;
        private TextBox tb_minToOrderAdd;
        private Label locationLabel;
        private TextBox tb_locationAdd;
        private Label stockDetailLabel;
        private TextBox tb_qtyAdd;
        private Label categoryDetailLabel;
        private Label codeDetailLabel;
        private TextBox cb_codeAdd;
        private Label sizeLabel;
        private TextBox tb_sizeWidthAdd;
        private Label nameLabel;
        private TextBox tb_nameAdd;
        private Label lotNumberLabel;
        private TextBox tb_lotNumberAdd;
        private Label label2;
        private Label productStatusLabel;
        private ComboBox cb_typeAdd;
        private ComboBox cb_productStatusAdd;
        private ComboBox cb_inventoryStatusAdd;
        private Label inventoryLabel;
        private DateTimePicker dtp_DateAddedAdd;
        private DateTimePicker dtp_DateUpdatedAdd;
        private Label dateAddedLabel;
        private Label updatedLabel;
    }
}