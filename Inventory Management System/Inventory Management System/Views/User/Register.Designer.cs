namespace Inventory_Management_System.Views.User
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
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.createButton = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationButton = new System.Windows.Forms.ToolStripMenuItem();
            this.statsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.infoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.accountButton = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeButton,
            this.createButton,
            this.notificationButton,
            this.statsButton,
            this.infoButton,
            this.accountButton,
            this.logoutButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(207, 1399);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeButton.ForeColor = System.Drawing.Color.Transparent;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(192, 100);
            this.homeButton.Text = "H";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createButton.ForeColor = System.Drawing.Color.Transparent;
            this.createButton.Image = ((System.Drawing.Image)(resources.GetObject("createButton.Image")));
            this.createButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(192, 100);
            this.createButton.Text = "C";
            this.createButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notificationButton
            // 
            this.notificationButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notificationButton.ForeColor = System.Drawing.Color.Transparent;
            this.notificationButton.Image = ((System.Drawing.Image)(resources.GetObject("notificationButton.Image")));
            this.notificationButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(192, 100);
            this.notificationButton.Text = "N";
            this.notificationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statsButton
            // 
            this.statsButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statsButton.ForeColor = System.Drawing.Color.Transparent;
            this.statsButton.Image = ((System.Drawing.Image)(resources.GetObject("statsButton.Image")));
            this.statsButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(192, 100);
            this.statsButton.Text = "S";
            this.statsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoButton
            // 
            this.infoButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoButton.ForeColor = System.Drawing.Color.Transparent;
            this.infoButton.Image = ((System.Drawing.Image)(resources.GetObject("infoButton.Image")));
            this.infoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.infoButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(192, 100);
            this.infoButton.Text = "I";
            // 
            // accountButton
            // 
            this.accountButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountButton.ForeColor = System.Drawing.Color.Transparent;
            this.accountButton.Image = ((System.Drawing.Image)(resources.GetObject("accountButton.Image")));
            this.accountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accountButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountButton.Margin = new System.Windows.Forms.Padding(0, 127, 0, 0);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(192, 100);
            this.accountButton.Text = "A";
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.ForeColor = System.Drawing.Color.Transparent;
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(192, 100);
            this.logoutButton.Text = "O";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(2084, 1399);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.usernameTxt);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private TextBox usernameTxt;
        private PictureBox pictureBox1;
        private TextBox passwordTxt;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeButton;
        private ToolStripMenuItem createButton;
        private ToolStripMenuItem notificationButton;
        private ToolStripMenuItem statsButton;
        private ToolStripMenuItem infoButton;
        private ToolStripMenuItem accountButton;
        private ToolStripMenuItem logoutButton;
    }
}