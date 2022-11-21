namespace Inventory_Management_System.Views.User
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.createButton = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationButton = new System.Windows.Forms.ToolStripMenuItem();
            this.statsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.infoButton = new System.Windows.Forms.ToolStripMenuItem();
            this.accountButton = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.mainTable = new System.Windows.Forms.DataGridView();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterDropDown = new System.Windows.Forms.ComboBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.orderByLabel = new System.Windows.Forms.Label();
            this.orderDropDown = new System.Windows.Forms.ComboBox();
            this.loggedInAsLabel = new System.Windows.Forms.Label();
            this.pageNumLabel = new System.Windows.Forms.Label();
            this.leftPageButton = new System.Windows.Forms.Button();
            this.rightPageButton = new System.Windows.Forms.Button();
            this.leftSkipPageButton = new System.Windows.Forms.Button();
            this.rightSkipPageButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeButton.ForeColor = System.Drawing.Color.Transparent;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(125, 78);
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
            this.createButton.Size = new System.Drawing.Size(125, 78);
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
            this.notificationButton.Size = new System.Drawing.Size(125, 64);
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
            this.statsButton.Size = new System.Drawing.Size(125, 78);
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
            this.infoButton.Size = new System.Drawing.Size(125, 64);
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
            this.accountButton.Size = new System.Drawing.Size(125, 66);
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
            this.logoutButton.Size = new System.Drawing.Size(125, 69);
            this.logoutButton.Text = "O";
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.SystemColors.Control;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchLabel.Location = new System.Drawing.Point(218, 49);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(100, 44);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(218, 96);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(216, 34);
            this.searchTextBox.TabIndex = 2;
            // 
            // mainTable
            // 
            this.mainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainTable.Location = new System.Drawing.Point(218, 166);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowHeadersWidth = 51;
            this.mainTable.RowTemplate.Height = 29;
            this.mainTable.Size = new System.Drawing.Size(724, 360);
            this.mainTable.TabIndex = 3;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filterLabel.Location = new System.Drawing.Point(461, 49);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(99, 31);
            this.filterLabel.TabIndex = 4;
            this.filterLabel.Text = "Filter By";
            // 
            // filterDropDown
            // 
            this.filterDropDown.FormattingEnabled = true;
            this.filterDropDown.Items.AddRange(new object[] {
            "Code",
            "Name",
            "Size",
            "Stock"});
            this.filterDropDown.Location = new System.Drawing.Point(461, 96);
            this.filterDropDown.Name = "filterDropDown";
            this.filterDropDown.Size = new System.Drawing.Size(225, 36);
            this.filterDropDown.TabIndex = 5;
            this.filterDropDown.Text = "Select";
            this.filterDropDown.SelectedIndexChanged += new System.EventHandler(this.filterDropDown_SelectedIndexChanged);
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.Transparent;
            this.applyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.applyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.applyButton.Location = new System.Drawing.Point(983, 94);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(105, 43);
            this.applyButton.TabIndex = 6;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(820, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 7;
            // 
            // orderByLabel
            // 
            this.orderByLabel.AutoSize = true;
            this.orderByLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderByLabel.Location = new System.Drawing.Point(723, 49);
            this.orderByLabel.Name = "orderByLabel";
            this.orderByLabel.Size = new System.Drawing.Size(107, 31);
            this.orderByLabel.TabIndex = 8;
            this.orderByLabel.Text = "Order By";
            // 
            // orderDropDown
            // 
            this.orderDropDown.FormattingEnabled = true;
            this.orderDropDown.Items.AddRange(new object[] {
            "Code",
            "Name",
            "Size",
            "Stock"});
            this.orderDropDown.Location = new System.Drawing.Point(723, 94);
            this.orderDropDown.Name = "orderDropDown";
            this.orderDropDown.Size = new System.Drawing.Size(219, 36);
            this.orderDropDown.TabIndex = 9;
            this.orderDropDown.Text = "Select";
            // 
            // loggedInAsLabel
            // 
            this.loggedInAsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.loggedInAsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loggedInAsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loggedInAsLabel.Location = new System.Drawing.Point(178, 581);
            this.loggedInAsLabel.Name = "loggedInAsLabel";
            this.loggedInAsLabel.Size = new System.Drawing.Size(163, 40);
            this.loggedInAsLabel.TabIndex = 10;
            this.loggedInAsLabel.Text = "Logged in As:";
            // 
            // pageNumLabel
            // 
            this.pageNumLabel.BackColor = System.Drawing.SystemColors.Control;
            this.pageNumLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pageNumLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pageNumLabel.Location = new System.Drawing.Point(829, 559);
            this.pageNumLabel.Name = "pageNumLabel";
            this.pageNumLabel.Size = new System.Drawing.Size(24, 40);
            this.pageNumLabel.TabIndex = 11;
            this.pageNumLabel.Text = "1";
            // 
            // leftPageButton
            // 
            this.leftPageButton.BackColor = System.Drawing.Color.Transparent;
            this.leftPageButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leftPageButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leftPageButton.Location = new System.Drawing.Point(799, 554);
            this.leftPageButton.Name = "leftPageButton";
            this.leftPageButton.Size = new System.Drawing.Size(31, 40);
            this.leftPageButton.TabIndex = 12;
            this.leftPageButton.Text = "<";
            this.leftPageButton.UseVisualStyleBackColor = false;
            // 
            // rightPageButton
            // 
            this.rightPageButton.BackColor = System.Drawing.Color.Transparent;
            this.rightPageButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rightPageButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rightPageButton.Location = new System.Drawing.Point(850, 554);
            this.rightPageButton.Name = "rightPageButton";
            this.rightPageButton.Size = new System.Drawing.Size(31, 40);
            this.rightPageButton.TabIndex = 13;
            this.rightPageButton.Text = ">";
            this.rightPageButton.UseVisualStyleBackColor = false;
            // 
            // leftSkipPageButton
            // 
            this.leftSkipPageButton.BackColor = System.Drawing.Color.Transparent;
            this.leftSkipPageButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leftSkipPageButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leftSkipPageButton.Location = new System.Drawing.Point(730, 554);
            this.leftSkipPageButton.Name = "leftSkipPageButton";
            this.leftSkipPageButton.Size = new System.Drawing.Size(63, 40);
            this.leftSkipPageButton.TabIndex = 14;
            this.leftSkipPageButton.Text = "|<<";
            this.leftSkipPageButton.UseVisualStyleBackColor = false;
            // 
            // rightSkipPageButton
            // 
            this.rightSkipPageButton.BackColor = System.Drawing.Color.Transparent;
            this.rightSkipPageButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rightSkipPageButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rightSkipPageButton.Location = new System.Drawing.Point(887, 554);
            this.rightSkipPageButton.Name = "rightSkipPageButton";
            this.rightSkipPageButton.Size = new System.Drawing.Size(63, 40);
            this.rightSkipPageButton.TabIndex = 15;
            this.rightSkipPageButton.Text = ">>|";
            this.rightSkipPageButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(968, 593);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "*current Time*";
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.BackColor = System.Drawing.SystemColors.Control;
            this.currentUserLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentUserLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentUserLabel.Location = new System.Drawing.Point(337, 581);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(167, 40);
            this.currentUserLabel.TabIndex = 17;
            this.currentUserLabel.Text = "*Current User*";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rightSkipPageButton);
            this.Controls.Add(this.leftSkipPageButton);
            this.Controls.Add(this.rightPageButton);
            this.Controls.Add(this.leftPageButton);
            this.Controls.Add(this.pageNumLabel);
            this.Controls.Add(this.loggedInAsLabel);
            this.Controls.Add(this.orderDropDown);
            this.Controls.Add(this.orderByLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.filterDropDown);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeButton;
        private ToolStripMenuItem createButton;
        private ToolStripMenuItem notificationButton;
        private ToolStripMenuItem statsButton;
        private ToolStripMenuItem infoButton;
        private ToolStripMenuItem accountButton;
        private ToolStripMenuItem logoutButton;
        private Label searchLabel;
        private TextBox searchTextBox;
        private DataGridView mainTable;
        private Label filterLabel;
        private ComboBox filterDropDown;
        private Button applyButton;
        private Label label1;
        private Label orderByLabel;
        private ComboBox orderDropDown;
        private Label loggedInAsLabel;
        private Label pageNumLabel;
        private Button leftPageButton;
        private Button rightPageButton;
        private Button leftSkipPageButton;
        private Button rightSkipPageButton;
        private Label label2;
        private Label currentUserLabel;
    }
}