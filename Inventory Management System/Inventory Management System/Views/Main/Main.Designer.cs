namespace Inventory_Management_System.Views.Main
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.insertButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.alertButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.titleBar = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.cancelLoginButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.revealPasswordButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.Timer(this.components);
            this.panel10 = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(179, 760);
            this.sidebar.MinimumSize = new System.Drawing.Size(66, 483);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(66, 703);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(15, 9);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(33, 29);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.homeButton);
            this.panel2.Location = new System.Drawing.Point(3, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 55);
            this.panel2.TabIndex = 0;
            // 
            // homeButton
            // 
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Image = global::Inventory_Management_System.Properties.Resources.home_;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(-19, -3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.homeButton.Size = new System.Drawing.Size(197, 68);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "     Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            this.homeButton.Leave += new System.EventHandler(this.deactiveButton);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.insertButton);
            this.panel3.Location = new System.Drawing.Point(3, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 55);
            this.panel3.TabIndex = 1;
            // 
            // insertButton
            // 
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertButton.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertButton.ForeColor = System.Drawing.Color.White;
            this.insertButton.Image = ((System.Drawing.Image)(resources.GetObject("insertButton.Image")));
            this.insertButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertButton.Location = new System.Drawing.Point(-18, -3);
            this.insertButton.Name = "insertButton";
            this.insertButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.insertButton.Size = new System.Drawing.Size(197, 68);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "     Add Item";
            this.insertButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            this.insertButton.Leave += new System.EventHandler(this.deactiveButton);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.alertButton);
            this.panel4.Location = new System.Drawing.Point(3, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(161, 55);
            this.panel4.TabIndex = 2;
            // 
            // alertButton
            // 
            this.alertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alertButton.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alertButton.ForeColor = System.Drawing.Color.White;
            this.alertButton.Image = ((System.Drawing.Image)(resources.GetObject("alertButton.Image")));
            this.alertButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alertButton.Location = new System.Drawing.Point(-21, -3);
            this.alertButton.Name = "alertButton";
            this.alertButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.alertButton.Size = new System.Drawing.Size(197, 68);
            this.alertButton.TabIndex = 1;
            this.alertButton.Text = "     Alert";
            this.alertButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alertButton.UseVisualStyleBackColor = true;
            this.alertButton.Click += new System.EventHandler(this.alertButton_Click);
            this.alertButton.Leave += new System.EventHandler(this.deactiveButton);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.reportButton);
            this.panel5.Location = new System.Drawing.Point(3, 252);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(161, 55);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button5);
            this.panel6.Location = new System.Drawing.Point(0, 52);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(161, 55);
            this.panel6.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::Inventory_Management_System.Properties.Resources.home_;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-13, -3);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(197, 68);
            this.button5.TabIndex = 1;
            this.button5.Text = "    Home";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // reportButton
            // 
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportButton.ForeColor = System.Drawing.Color.White;
            this.reportButton.Image = ((System.Drawing.Image)(resources.GetObject("reportButton.Image")));
            this.reportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportButton.Location = new System.Drawing.Point(-22, -3);
            this.reportButton.Name = "reportButton";
            this.reportButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.reportButton.Size = new System.Drawing.Size(197, 68);
            this.reportButton.TabIndex = 1;
            this.reportButton.Text = "     Report";
            this.reportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            this.reportButton.Leave += new System.EventHandler(this.deactiveButton);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.helpButton);
            this.panel8.Location = new System.Drawing.Point(3, 313);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(161, 55);
            this.panel8.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button6);
            this.panel9.Location = new System.Drawing.Point(0, 52);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(161, 55);
            this.panel9.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::Inventory_Management_System.Properties.Resources.home_;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-13, -3);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(197, 68);
            this.button6.TabIndex = 1;
            this.button6.Text = "    Home";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpButton.Location = new System.Drawing.Point(-22, -3);
            this.helpButton.Name = "helpButton";
            this.helpButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.helpButton.Size = new System.Drawing.Size(197, 68);
            this.helpButton.TabIndex = 1;
            this.helpButton.Text = "     Help";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            this.helpButton.Leave += new System.EventHandler(this.deactiveButton);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.logoutButton);
            this.panel7.Location = new System.Drawing.Point(3, 621);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 250, 3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(161, 55);
            this.panel7.TabIndex = 4;
            // 
            // logoutButton
            // 
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(-21, -3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.logoutButton.Size = new System.Drawing.Size(197, 68);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "     Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sideBarTimer_tick);
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.titleBar.Controls.Add(this.titleLabel);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(66, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1016, 63);
            this.titleBar.TabIndex = 1;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(423, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(65, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "LOGIN";
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.SystemColors.Control;
            this.containerPanel.Controls.Add(this.cancelLoginButton);
            this.containerPanel.Controls.Add(this.loginButton);
            this.containerPanel.Controls.Add(this.revealPasswordButton);
            this.containerPanel.Controls.Add(this.passwordTextBox);
            this.containerPanel.Controls.Add(this.userNameTextBox);
            this.containerPanel.Controls.Add(this.pictureBox1);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.ForeColor = System.Drawing.Color.Black;
            this.containerPanel.Location = new System.Drawing.Point(66, 63);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1016, 640);
            this.containerPanel.TabIndex = 2;
            // 
            // cancelLoginButton
            // 
            this.cancelLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(21)))), ((int)(((byte)(46)))));
            this.cancelLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelLoginButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelLoginButton.Location = new System.Drawing.Point(368, 426);
            this.cancelLoginButton.Name = "cancelLoginButton";
            this.cancelLoginButton.Padding = new System.Windows.Forms.Padding(2);
            this.cancelLoginButton.Size = new System.Drawing.Size(94, 34);
            this.cancelLoginButton.TabIndex = 5;
            this.cancelLoginButton.Text = "CANCEL";
            this.cancelLoginButton.UseVisualStyleBackColor = false;
            this.cancelLoginButton.Click += new System.EventHandler(this.cancelLoginButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(128)))), ((int)(((byte)(82)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Location = new System.Drawing.Point(493, 426);
            this.loginButton.Name = "loginButton";
            this.loginButton.Padding = new System.Windows.Forms.Padding(2);
            this.loginButton.Size = new System.Drawing.Size(94, 34);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // revealPasswordButton
            // 
            this.revealPasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.revealPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.revealPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revealPasswordButton.ForeColor = System.Drawing.Color.Transparent;
            this.revealPasswordButton.Image = ((System.Drawing.Image)(resources.GetObject("revealPasswordButton.Image")));
            this.revealPasswordButton.Location = new System.Drawing.Point(591, 349);
            this.revealPasswordButton.Name = "revealPasswordButton";
            this.revealPasswordButton.Size = new System.Drawing.Size(41, 30);
            this.revealPasswordButton.TabIndex = 3;
            this.revealPasswordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.revealPasswordButton.UseVisualStyleBackColor = false;
            this.revealPasswordButton.Click += new System.EventHandler(this.revealPasswordButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.Location = new System.Drawing.Point(368, 347);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PlaceholderText = "Enter Password";
            this.passwordTextBox.Size = new System.Drawing.Size(219, 34);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameTextBox.Location = new System.Drawing.Point(368, 281);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PlaceholderText = "Enter username";
            this.userNameTextBox.Size = new System.Drawing.Size(219, 34);
            this.userNameTextBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(368, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 191);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentDateLabel.Location = new System.Drawing.Point(768, 6);
            this.currentDateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(152, 18);
            this.currentDateLabel.TabIndex = 12;
            this.currentDateLabel.Text = "10:00 | 2022/12/07";
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentUserLabel.Location = new System.Drawing.Point(6, 6);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(256, 18);
            this.currentUserLabel.TabIndex = 11;
            this.currentUserLabel.Text = "Logged in as : Label Technician";
            // 
            // dateTime
            // 
            this.dateTime.Enabled = true;
            this.dateTime.Tick += new System.EventHandler(this.dateTime_Tick);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.currentUserLabel);
            this.panel10.Controls.Add(this.currentDateLabel);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(66, 673);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1016, 30);
            this.panel10.TabIndex = 13;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.sidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 750);
            this.MinimumSize = new System.Drawing.Size(1100, 750);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monica";
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Button homeButton;
        private Panel panel2;
        private Panel panel3;
        private Button insertButton;
        private Panel panel4;
        private Button alertButton;
        private Panel panel5;
        private Button reportButton;
        private Panel panel6;
        private Button button5;
        private Label label1;
        private PictureBox menuButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel panel7;
        private Button logoutButton;
        private Panel panel8;
        private Panel panel9;
        private Button button6;
        private Button helpButton;
        private Panel titleBar;
        private Label titleLabel;
        private Panel containerPanel;
        private PictureBox pictureBox1;
        private Button revealPasswordButton;
        private TextBox passwordTextBox;
        private TextBox userNameTextBox;
        private Button cancelLoginButton;
        private Button loginButton;
        private Label currentUserLabel;
        private Label currentDateLabel;
        private System.Windows.Forms.Timer dateTime;
        private Panel panel10;
    }
}