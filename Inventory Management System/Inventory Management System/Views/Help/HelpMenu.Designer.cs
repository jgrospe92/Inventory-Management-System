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
            this.helpMenuLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginHelpMenuLink = new System.Windows.Forms.LinkLabel();
            this.deleteHelpMenuLink = new System.Windows.Forms.LinkLabel();
            this.createHelpMenuLink = new System.Windows.Forms.LinkLabel();
            this.updateHelpMenuLink = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpMenuLabel
            // 
            this.helpMenuLabel.AutoSize = true;
            this.helpMenuLabel.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpMenuLabel.Location = new System.Drawing.Point(168, 78);
            this.helpMenuLabel.Name = "helpMenuLabel";
            this.helpMenuLabel.Size = new System.Drawing.Size(389, 28);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 544);
            this.panel1.TabIndex = 21;
            // 
            // loginHelpMenuLink
            // 
            this.loginHelpMenuLink.AutoSize = true;
            this.loginHelpMenuLink.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginHelpMenuLink.Location = new System.Drawing.Point(24, 78);
            this.loginHelpMenuLink.Name = "loginHelpMenuLink";
            this.loginHelpMenuLink.Size = new System.Drawing.Size(90, 33);
            this.loginHelpMenuLink.TabIndex = 4;
            this.loginHelpMenuLink.TabStop = true;
            this.loginHelpMenuLink.Text = "Login";
            this.loginHelpMenuLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginHelpMenuLink_LinkClicked);
            // 
            // deleteHelpMenuLink
            // 
            this.deleteHelpMenuLink.AutoSize = true;
            this.deleteHelpMenuLink.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteHelpMenuLink.Location = new System.Drawing.Point(24, 313);
            this.deleteHelpMenuLink.Name = "deleteHelpMenuLink";
            this.deleteHelpMenuLink.Size = new System.Drawing.Size(105, 33);
            this.deleteHelpMenuLink.TabIndex = 7;
            this.deleteHelpMenuLink.TabStop = true;
            this.deleteHelpMenuLink.Text = "Delete";
            this.deleteHelpMenuLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deleteHelpMenuLink_LinkClicked);
            // 
            // createHelpMenuLink
            // 
            this.createHelpMenuLink.AutoSize = true;
            this.createHelpMenuLink.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createHelpMenuLink.Location = new System.Drawing.Point(24, 155);
            this.createHelpMenuLink.Name = "createHelpMenuLink";
            this.createHelpMenuLink.Size = new System.Drawing.Size(105, 33);
            this.createHelpMenuLink.TabIndex = 5;
            this.createHelpMenuLink.TabStop = true;
            this.createHelpMenuLink.Text = "Create";
            this.createHelpMenuLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createHelpMenuLink_LinkClicked);
            // 
            // updateHelpMenuLink
            // 
            this.updateHelpMenuLink.AutoSize = true;
            this.updateHelpMenuLink.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateHelpMenuLink.Location = new System.Drawing.Point(24, 233);
            this.updateHelpMenuLink.Name = "updateHelpMenuLink";
            this.updateHelpMenuLink.Size = new System.Drawing.Size(105, 33);
            this.updateHelpMenuLink.TabIndex = 6;
            this.updateHelpMenuLink.TabStop = true;
            this.updateHelpMenuLink.Text = "Update";
            this.updateHelpMenuLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updateHelpMenuLink_LinkClicked);
            // 
            // HelpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.helpMenuLabel);
            this.Name = "HelpMenu";
            this.Text = "HelpMenu";
            this.Load += new System.EventHandler(this.HelpMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}