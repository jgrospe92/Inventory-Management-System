namespace Inventory_Management_System.Views.Product
{
    partial class ProductDetails
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
            this.categoryDetailComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeHeightDetailTextBox = new System.Windows.Forms.TextBox();
            this.doneBtn = new System.Windows.Forms.Button();
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
            this.codeDetailTextBox = new System.Windows.Forms.TextBox();
            this.sizeDetailLabel = new System.Windows.Forms.Label();
            this.sizeWidthDetailTextBox = new System.Windows.Forms.TextBox();
            this.nameDetailLabel = new System.Windows.Forms.Label();
            this.nameDetailTextBox = new System.Windows.Forms.TextBox();
            this.lotNumberDetailLabel = new System.Windows.Forms.Label();
            this.lotNumberDetailTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // categoryDetailComboBox
            // 
            this.categoryDetailComboBox.FormattingEnabled = true;
            this.categoryDetailComboBox.Items.AddRange(new object[] {
            "white Plain",
            "colored",
            "sauces",
            "gravy",
            "seasoning",
            "marinade",
            "ink",
            "Other"});
            this.categoryDetailComboBox.Location = new System.Drawing.Point(459, 161);
            this.categoryDetailComboBox.Name = "categoryDetailComboBox";
            this.categoryDetailComboBox.Size = new System.Drawing.Size(277, 28);
            this.categoryDetailComboBox.TabIndex = 46;
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
            // sizeHeightDetailTextBox
            // 
            this.sizeHeightDetailTextBox.Location = new System.Drawing.Point(173, 259);
            this.sizeHeightDetailTextBox.Name = "sizeHeightDetailTextBox";
            this.sizeHeightDetailTextBox.PlaceholderText = "height";
            this.sizeHeightDetailTextBox.Size = new System.Drawing.Size(68, 27);
            this.sizeHeightDetailTextBox.TabIndex = 44;
            // 
            // doneBtn
            // 
            this.doneBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.doneBtn.ForeColor = System.Drawing.Color.White;
            this.doneBtn.Location = new System.Drawing.Point(600, 428);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(136, 52);
            this.doneBtn.TabIndex = 42;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = false;
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
            // codeDetailTextBox
            // 
            this.codeDetailTextBox.Location = new System.Drawing.Point(459, 73);
            this.codeDetailTextBox.Name = "codeDetailTextBox";
            this.codeDetailTextBox.PlaceholderText = "Enter item code";
            this.codeDetailTextBox.Size = new System.Drawing.Size(277, 27);
            this.codeDetailTextBox.TabIndex = 31;
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
            // sizeWidthDetailTextBox
            // 
            this.sizeWidthDetailTextBox.Location = new System.Drawing.Point(74, 259);
            this.sizeWidthDetailTextBox.Name = "sizeWidthDetailTextBox";
            this.sizeWidthDetailTextBox.PlaceholderText = "width";
            this.sizeWidthDetailTextBox.Size = new System.Drawing.Size(68, 27);
            this.sizeWidthDetailTextBox.TabIndex = 29;
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
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 512);
            this.Controls.Add(this.categoryDetailComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeHeightDetailTextBox);
            this.Controls.Add(this.doneBtn);
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
            this.Controls.Add(this.codeDetailTextBox);
            this.Controls.Add(this.sizeDetailLabel);
            this.Controls.Add(this.sizeWidthDetailTextBox);
            this.Controls.Add(this.nameDetailLabel);
            this.Controls.Add(this.nameDetailTextBox);
            this.Controls.Add(this.lotNumberDetailLabel);
            this.Controls.Add(this.lotNumberDetailTextBox);
            this.Name = "ProductDetails";
            this.Text = "ProductDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox categoryDetailComboBox;
        private Label label1;
        private TextBox sizeHeightDetailTextBox;
        private Button doneBtn;
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
        private TextBox codeDetailTextBox;
        private Label sizeDetailLabel;
        private TextBox sizeWidthDetailTextBox;
        private Label nameDetailLabel;
        private TextBox nameDetailTextBox;
        private Label lotNumberDetailLabel;
        private TextBox lotNumberDetailTextBox;
    }
}