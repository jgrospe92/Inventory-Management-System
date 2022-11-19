namespace Inventory_Management_System
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.homeBtn = new System.Windows.Forms.Button();
            this.filesBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.alertBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.homeBtn.Location = new System.Drawing.Point(12, 177);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(165, 103);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            // 
            // filesBtn
            // 
            this.filesBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.filesBtn.Location = new System.Drawing.Point(12, 306);
            this.filesBtn.Name = "filesBtn";
            this.filesBtn.Size = new System.Drawing.Size(165, 103);
            this.filesBtn.TabIndex = 1;
            this.filesBtn.Text = "Files";
            this.filesBtn.UseVisualStyleBackColor = true;
            // 
            // reportBtn
            // 
            this.reportBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.reportBtn.Location = new System.Drawing.Point(12, 573);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(165, 103);
            this.reportBtn.TabIndex = 3;
            this.reportBtn.Text = "Reports";
            this.reportBtn.UseVisualStyleBackColor = true;
            // 
            // alertBtn
            // 
            this.alertBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.alertBtn.Location = new System.Drawing.Point(12, 441);
            this.alertBtn.Name = "alertBtn";
            this.alertBtn.Size = new System.Drawing.Size(165, 103);
            this.alertBtn.TabIndex = 2;
            this.alertBtn.Text = "Alerts";
            this.alertBtn.UseVisualStyleBackColor = true;
            // 
            // helpBtn
            // 
            this.helpBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.helpBtn.Location = new System.Drawing.Point(12, 706);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(165, 103);
            this.helpBtn.TabIndex = 4;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = true;
            // 
            // userBtn
            // 
            this.userBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userBtn.Location = new System.Drawing.Point(12, 1067);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(155, 78);
            this.userBtn.TabIndex = 5;
            this.userBtn.Text = "User";
            this.userBtn.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logoutBtn.Location = new System.Drawing.Point(12, 1194);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(156, 83);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-5, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(2089, 135);
            this.textBox1.TabIndex = 7;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.usernameTxt.Location = new System.Drawing.Point(637, 929);
            this.usernameTxt.Multiline = true;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(950, 81);
            this.usernameTxt.TabIndex = 9;
            this.usernameTxt.Text = "Username";
            this.usernameTxt.Enter += new System.EventHandler(this.Username_Enter_Text);
            this.usernameTxt.Leave += new System.EventHandler(this.Username_Leave_Text);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(735, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(764, 624);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordTxt.Location = new System.Drawing.Point(637, 1101);
            this.passwordTxt.Multiline = true;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(950, 81);
            this.passwordTxt.TabIndex = 12;
            this.passwordTxt.Text = "Password";
            this.passwordTxt.Enter += new System.EventHandler(this.Password_Enter_Text);
            this.passwordTxt.Leave += new System.EventHandler(this.Password_Leave_Text);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(2084, 1399);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.userBtn);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.alertBtn);
            this.Controls.Add(this.filesBtn);
            this.Controls.Add(this.homeBtn);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button homeBtn;
        private Button filesBtn;
        private Button reportBtn;
        private Button alertBtn;
        private Button helpBtn;
        private Button userBtn;
        private Button logoutBtn;
        private TextBox textBox1;
        private TextBox usernameTxt;
        private PictureBox pictureBox1;
        private TextBox passwordTxt;
    }
}