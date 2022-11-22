namespace Inventory_Management_System.Views.Help
{
    partial class HelpMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpMenu));
            this.helpMenuLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginHelpMenuLink = new System.Windows.Forms.LinkLabel();
            this.deleteHelpMenuLink = new System.Windows.Forms.LinkLabel();
            this.createHelpMenuLink = new System.Windows.Forms.LinkLabel();
            this.updateHelpMenuLink = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createButton = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationButton = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountButton = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpMenuLabel
            // 
            this.helpMenuLabel.AutoSize = true;
            this.helpMenuLabel.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helpMenuLabel.Location = new System.Drawing.Point(310, 86);
            this.helpMenuLabel.Name = "helpMenuLabel";
            this.helpMenuLabel.Size = new System.Drawing.Size(353, 30);
            this.helpMenuLabel.TabIndex = 17;
            this.helpMenuLabel.Text = "Welcome to the Help Menu Page";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.loginHelpMenuLink);
            this.panel1.Controls.Add(this.deleteHelpMenuLink);
            this.panel1.Controls.Add(this.createHelpMenuLink);
            this.panel1.Controls.Add(this.updateHelpMenuLink);
            this.panel1.Location = new System.Drawing.Point(143, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 630);
            this.panel1.TabIndex = 21;
            // 
            // loginHelpMenuLink
            // 
            this.loginHelpMenuLink.AutoSize = true;
            this.loginHelpMenuLink.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginHelpMenuLink.Location = new System.Drawing.Point(24, 78);
            this.loginHelpMenuLink.Name = "loginHelpMenuLink";
            this.loginHelpMenuLink.Size = new System.Drawing.Size(85, 38);
            this.loginHelpMenuLink.TabIndex = 4;
            this.loginHelpMenuLink.TabStop = true;
            this.loginHelpMenuLink.Text = "Login";
            this.loginHelpMenuLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginHelpMenuLink_LinkClicked);
            // 
            // deleteHelpMenuLink
            // 
            this.deleteHelpMenuLink.AutoSize = true;
            this.deleteHelpMenuLink.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteHelpMenuLink.Location = new System.Drawing.Point(24, 313);
            this.deleteHelpMenuLink.Name = "deleteHelpMenuLink";
            this.deleteHelpMenuLink.Size = new System.Drawing.Size(98, 38);
            this.deleteHelpMenuLink.TabIndex = 7;
            this.deleteHelpMenuLink.TabStop = true;
            this.deleteHelpMenuLink.Text = "Delete";
            this.deleteHelpMenuLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deleteHelpMenuLink_LinkClicked);
            // 
            // createHelpMenuLink
            // 
            this.createHelpMenuLink.AutoSize = true;
            this.createHelpMenuLink.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createHelpMenuLink.Location = new System.Drawing.Point(24, 155);
            this.createHelpMenuLink.Name = "createHelpMenuLink";
            this.createHelpMenuLink.Size = new System.Drawing.Size(97, 38);
            this.createHelpMenuLink.TabIndex = 5;
            this.createHelpMenuLink.TabStop = true;
            this.createHelpMenuLink.Text = "Create";
            this.createHelpMenuLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createHelpMenuLink_LinkClicked);
            // 
            // updateHelpMenuLink
            // 
            this.updateHelpMenuLink.AutoSize = true;
            this.updateHelpMenuLink.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateHelpMenuLink.Location = new System.Drawing.Point(24, 233);
            this.updateHelpMenuLink.Name = "updateHelpMenuLink";
            this.updateHelpMenuLink.Size = new System.Drawing.Size(106, 38);
            this.updateHelpMenuLink.TabIndex = 6;
            this.updateHelpMenuLink.TabStop = true;
            this.updateHelpMenuLink.Text = "Update";
            this.updateHelpMenuLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updateHelpMenuLink_LinkClicked);
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
            this.menuStrip1.Size = new System.Drawing.Size(140, 630);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeButton
            // 
            this.homeButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeButton.ForeColor = System.Drawing.Color.Transparent;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(125, 76);
            this.homeButton.Text = "H";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(191, 46);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // createButton
            // 
            this.createButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem});
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createButton.ForeColor = System.Drawing.Color.Transparent;
            this.createButton.Image = ((System.Drawing.Image)(resources.GetObject("createButton.Image")));
            this.createButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(125, 78);
            this.createButton.Text = "C";
            this.createButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(196, 46);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // notificationButton
            // 
            this.notificationButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notificationToolStripMenuItem});
            this.notificationButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notificationButton.ForeColor = System.Drawing.Color.Transparent;
            this.notificationButton.Image = ((System.Drawing.Image)(resources.GetObject("notificationButton.Image")));
            this.notificationButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(125, 64);
            this.notificationButton.Text = "N";
            this.notificationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notificationToolStripMenuItem
            // 
            this.notificationToolStripMenuItem.Name = "notificationToolStripMenuItem";
            this.notificationToolStripMenuItem.Size = new System.Drawing.Size(264, 46);
            this.notificationToolStripMenuItem.Text = "Notification";
            // 
            // statsButton
            // 
            this.statsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.statsButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statsButton.ForeColor = System.Drawing.Color.Transparent;
            this.statsButton.Image = ((System.Drawing.Image)(resources.GetObject("statsButton.Image")));
            this.statsButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(125, 78);
            this.statsButton.Text = "S";
            this.statsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(199, 46);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // infoButton
            // 
            this.infoButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.infoButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoButton.ForeColor = System.Drawing.Color.Transparent;
            this.infoButton.Image = ((System.Drawing.Image)(resources.GetObject("infoButton.Image")));
            this.infoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.infoButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(125, 66);
            this.infoButton.Text = "I";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(172, 46);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // accountButton
            // 
            this.accountButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem});
            this.accountButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountButton.ForeColor = System.Drawing.Color.Transparent;
            this.accountButton.Image = ((System.Drawing.Image)(resources.GetObject("accountButton.Image")));
            this.accountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accountButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountButton.Margin = new System.Windows.Forms.Padding(0, 127, 0, 0);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(125, 66);
            this.accountButton.Text = "A";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(170, 46);
            this.userToolStripMenuItem.Text = "User";
            // 
            // logoutButton
            // 
            this.logoutButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.ForeColor = System.Drawing.Color.Transparent;
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(125, 69);
            this.logoutButton.Text = "O";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(205, 46);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // HelpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.helpMenuLabel);
            this.Name = "HelpMenu";
            this.Text = "HelpMenu";
            this.Load += new System.EventHandler(this.HelpMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label helpMenuLabel;
        private Panel panel1;
        private LinkLabel loginHelpMenuLink;
        private LinkLabel deleteHelpMenuLink;
        private LinkLabel createHelpMenuLink;
        private LinkLabel updateHelpMenuLink;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeButton;
        private ToolStripMenuItem createButton;
        private ToolStripMenuItem notificationButton;
        private ToolStripMenuItem statsButton;
        private ToolStripMenuItem infoButton;
        private ToolStripMenuItem accountButton;
        private ToolStripMenuItem logoutButton;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem notificationToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}