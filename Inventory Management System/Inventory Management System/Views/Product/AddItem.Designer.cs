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
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_sizeHeight = new System.Windows.Forms.TextBox();
            this.btnCreateCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.brandDetailLabel = new System.Windows.Forms.Label();
            this.brandDetailTextBox = new System.Windows.Forms.TextBox();
            this.notifyAtDetailLabel = new System.Windows.Forms.Label();
            this.notifyAtDetailTextBox = new System.Windows.Forms.TextBox();
            this.locationDetailLabel = new System.Windows.Forms.Label();
            this.locationDetailTextBox = new System.Windows.Forms.TextBox();
            this.stockDetailLabel = new System.Windows.Forms.Label();
            this.stockDetailTextBox = new System.Windows.Forms.TextBox();
            this.categoryDetailLabel = new System.Windows.Forms.Label();
            this.codeDetailLabel = new System.Windows.Forms.Label();
            this.codeCreateTextBox = new System.Windows.Forms.TextBox();
            this.sizeDetailLabel = new System.Windows.Forms.Label();
            this.tb_sizeWidth = new System.Windows.Forms.TextBox();
            this.nameDetailLabel = new System.Windows.Forms.Label();
            this.nameDetailTextBox = new System.Windows.Forms.TextBox();
            this.lotNumberDetailLabel = new System.Windows.Forms.Label();
            this.lotNumberDetailTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Items.AddRange(new object[] {
            "white Plain",
            "colored",
            "sauces",
            "gravy",
            "seasoning",
            "marinade",
            "ink",
            "Other"});
            this.cb_category.Location = new System.Drawing.Point(459, 161);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(277, 28);
            this.cb_category.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(142, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "X";
            // 
            // tb_sizeHeight
            // 
            this.tb_sizeHeight.Location = new System.Drawing.Point(173, 259);
            this.tb_sizeHeight.Name = "tb_sizeHeight";
            this.tb_sizeHeight.PlaceholderText = "height";
            this.tb_sizeHeight.Size = new System.Drawing.Size(68, 27);
            this.tb_sizeHeight.TabIndex = 44;
            // 
            // btnCreateCancel
            // 
            this.btnCreateCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCreateCancel.ForeColor = System.Drawing.Color.White;
            this.btnCreateCancel.Location = new System.Drawing.Point(446, 428);
            this.btnCreateCancel.Name = "btnCreateCancel";
            this.btnCreateCancel.Size = new System.Drawing.Size(136, 52);
            this.btnCreateCancel.TabIndex = 43;
            this.btnCreateCancel.Text = "Cancel";
            this.btnCreateCancel.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(600, 428);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(136, 52);
            this.btnCreate.TabIndex = 42;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // brandDetailLabel
            // 
            this.brandDetailLabel.AutoSize = true;
            this.brandDetailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.brandDetailLabel.Location = new System.Drawing.Point(459, 316);
            this.brandDetailLabel.Name = "brandDetailLabel";
            this.brandDetailLabel.Size = new System.Drawing.Size(68, 28);
            this.brandDetailLabel.TabIndex = 41;
            this.brandDetailLabel.Text = "Brand";
            // 
            // brandDetailTextBox
            // 
            this.brandDetailTextBox.Location = new System.Drawing.Point(459, 356);
            this.brandDetailTextBox.Name = "brandDetailTextBox";
            this.brandDetailTextBox.PlaceholderText = "Enter product brand (ex: Rosehill )";
            this.brandDetailTextBox.Size = new System.Drawing.Size(277, 27);
            this.brandDetailTextBox.TabIndex = 40;
            // 
            // notifyAtDetailLabel
            // 
            this.notifyAtDetailLabel.AutoSize = true;
            this.notifyAtDetailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notifyAtDetailLabel.Location = new System.Drawing.Point(74, 413);
            this.notifyAtDetailLabel.Name = "notifyAtDetailLabel";
            this.notifyAtDetailLabel.Size = new System.Drawing.Size(212, 28);
            this.notifyAtDetailLabel.TabIndex = 39;
            this.notifyAtDetailLabel.Text = "Minimum To Reorder";
            // 
            // notifyAtDetailTextBox
            // 
            this.notifyAtDetailTextBox.Location = new System.Drawing.Point(74, 453);
            this.notifyAtDetailTextBox.Name = "notifyAtDetailTextBox";
            this.notifyAtDetailTextBox.PlaceholderText = "Enter minium amount to reorder";
            this.notifyAtDetailTextBox.Size = new System.Drawing.Size(277, 27);
            this.notifyAtDetailTextBox.TabIndex = 38;
            // 
            // locationDetailLabel
            // 
            this.locationDetailLabel.AutoSize = true;
            this.locationDetailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.locationDetailLabel.Location = new System.Drawing.Point(74, 316);
            this.locationDetailLabel.Name = "locationDetailLabel";
            this.locationDetailLabel.Size = new System.Drawing.Size(93, 28);
            this.locationDetailLabel.TabIndex = 37;
            this.locationDetailLabel.Text = "Location";
            // 
            // locationDetailTextBox
            // 
            this.locationDetailTextBox.Location = new System.Drawing.Point(74, 356);
            this.locationDetailTextBox.Name = "locationDetailTextBox";
            this.locationDetailTextBox.PlaceholderText = "Enter Item location";
            this.locationDetailTextBox.Size = new System.Drawing.Size(277, 27);
            this.locationDetailTextBox.TabIndex = 36;
            // 
            // stockDetailLabel
            // 
            this.stockDetailLabel.AutoSize = true;
            this.stockDetailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stockDetailLabel.Location = new System.Drawing.Point(459, 219);
            this.stockDetailLabel.Name = "stockDetailLabel";
            this.stockDetailLabel.Size = new System.Drawing.Size(64, 28);
            this.stockDetailLabel.TabIndex = 35;
            this.stockDetailLabel.Text = "Stock";
            // 
            // stockDetailTextBox
            // 
            this.stockDetailTextBox.Location = new System.Drawing.Point(459, 259);
            this.stockDetailTextBox.Name = "stockDetailTextBox";
            this.stockDetailTextBox.PlaceholderText = "Enter product quantity";
            this.stockDetailTextBox.Size = new System.Drawing.Size(277, 27);
            this.stockDetailTextBox.TabIndex = 34;
            // 
            // categoryDetailLabel
            // 
            this.categoryDetailLabel.AutoSize = true;
            this.categoryDetailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryDetailLabel.Location = new System.Drawing.Point(459, 122);
            this.categoryDetailLabel.Name = "categoryDetailLabel";
            this.categoryDetailLabel.Size = new System.Drawing.Size(98, 28);
            this.categoryDetailLabel.TabIndex = 33;
            this.categoryDetailLabel.Text = "Category";
            // 
            // codeDetailLabel
            // 
            this.codeDetailLabel.AutoSize = true;
            this.codeDetailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codeDetailLabel.Location = new System.Drawing.Point(459, 33);
            this.codeDetailLabel.Name = "codeDetailLabel";
            this.codeDetailLabel.Size = new System.Drawing.Size(59, 28);
            this.codeDetailLabel.TabIndex = 32;
            this.codeDetailLabel.Text = "Code";
            // 
            // codeCreateTextBox
            // 
            this.codeCreateTextBox.Location = new System.Drawing.Point(459, 73);
            this.codeCreateTextBox.Name = "codeCreateTextBox";
            this.codeCreateTextBox.PlaceholderText = "Enter item code";
            this.codeCreateTextBox.Size = new System.Drawing.Size(277, 27);
            this.codeCreateTextBox.TabIndex = 31;
            // 
            // sizeDetailLabel
            // 
            this.sizeDetailLabel.AutoSize = true;
            this.sizeDetailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sizeDetailLabel.Location = new System.Drawing.Point(74, 219);
            this.sizeDetailLabel.Name = "sizeDetailLabel";
            this.sizeDetailLabel.Size = new System.Drawing.Size(50, 28);
            this.sizeDetailLabel.TabIndex = 30;
            this.sizeDetailLabel.Text = "Size";
            // 
            // tb_sizeWidth
            // 
            this.tb_sizeWidth.Location = new System.Drawing.Point(74, 259);
            this.tb_sizeWidth.Name = "tb_sizeWidth";
            this.tb_sizeWidth.PlaceholderText = "width";
            this.tb_sizeWidth.Size = new System.Drawing.Size(68, 27);
            this.tb_sizeWidth.TabIndex = 29;
            // 
            // nameDetailLabel
            // 
            this.nameDetailLabel.AutoSize = true;
            this.nameDetailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameDetailLabel.Location = new System.Drawing.Point(74, 122);
            this.nameDetailLabel.Name = "nameDetailLabel";
            this.nameDetailLabel.Size = new System.Drawing.Size(68, 28);
            this.nameDetailLabel.TabIndex = 28;
            this.nameDetailLabel.Text = "Name";
            // 
            // nameDetailTextBox
            // 
            this.nameDetailTextBox.Location = new System.Drawing.Point(74, 162);
            this.nameDetailTextBox.Name = "nameDetailTextBox";
            this.nameDetailTextBox.PlaceholderText = "Enter Name";
            this.nameDetailTextBox.Size = new System.Drawing.Size(277, 27);
            this.nameDetailTextBox.TabIndex = 27;
            // 
            // lotNumberDetailLabel
            // 
            this.lotNumberDetailLabel.AutoSize = true;
            this.lotNumberDetailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lotNumberDetailLabel.Location = new System.Drawing.Point(74, 33);
            this.lotNumberDetailLabel.Name = "lotNumberDetailLabel";
            this.lotNumberDetailLabel.Size = new System.Drawing.Size(125, 28);
            this.lotNumberDetailLabel.TabIndex = 26;
            this.lotNumberDetailLabel.Text = "Lot Number";
            // 
            // lotNumberDetailTextBox
            // 
            this.lotNumberDetailTextBox.Location = new System.Drawing.Point(74, 73);
            this.lotNumberDetailTextBox.Name = "lotNumberDetailTextBox";
            this.lotNumberDetailTextBox.PlaceholderText = "Enter Lot Number";
            this.lotNumberDetailTextBox.Size = new System.Drawing.Size(277, 27);
            this.lotNumberDetailTextBox.TabIndex = 25;
            // 
            // createProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 512);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_sizeHeight);
            this.Controls.Add(this.btnCreateCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.brandDetailLabel);
            this.Controls.Add(this.brandDetailTextBox);
            this.Controls.Add(this.notifyAtDetailLabel);
            this.Controls.Add(this.notifyAtDetailTextBox);
            this.Controls.Add(this.locationDetailLabel);
            this.Controls.Add(this.locationDetailTextBox);
            this.Controls.Add(this.stockDetailLabel);
            this.Controls.Add(this.stockDetailTextBox);
            this.Controls.Add(this.categoryDetailLabel);
            this.Controls.Add(this.codeDetailLabel);
            this.Controls.Add(this.codeCreateTextBox);
            this.Controls.Add(this.sizeDetailLabel);
            this.Controls.Add(this.tb_sizeWidth);
            this.Controls.Add(this.nameDetailLabel);
            this.Controls.Add(this.nameDetailTextBox);
            this.Controls.Add(this.lotNumberDetailLabel);
            this.Controls.Add(this.lotNumberDetailTextBox);
            this.Name = "createProduct";
            this.Text = "createProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cb_category;
        private Label label1;
        private TextBox tb_sizeHeight;
        private Button btnCreateCancel;
        private Button btnCreate;
        private Label brandDetailLabel;
        private TextBox brandDetailTextBox;
        private Label notifyAtDetailLabel;
        private TextBox notifyAtDetailTextBox;
        private Label locationDetailLabel;
        private TextBox locationDetailTextBox;
        private Label stockDetailLabel;
        private TextBox stockDetailTextBox;
        private Label categoryDetailLabel;
        private Label codeDetailLabel;
        private TextBox codeCreateTextBox;
        private Label sizeDetailLabel;
        private TextBox tb_sizeWidth;
        private Label nameDetailLabel;
        private TextBox nameDetailTextBox;
        private Label lotNumberDetailLabel;
        private TextBox lotNumberDetailTextBox;
    }
}