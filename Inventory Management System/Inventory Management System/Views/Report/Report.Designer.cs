namespace Inventory_Management_System.Views.Report
{
    partial class Report
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
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.curretUserLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.homeProductListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.reportTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentDateLabel.Location = new System.Drawing.Point(746, 547);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(208, 23);
            this.currentDateLabel.TabIndex = 21;
            this.currentDateLabel.Text = "10:00 | 2022/12/07";
            // 
            // curretUserLabel
            // 
            this.curretUserLabel.AutoSize = true;
            this.curretUserLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.curretUserLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.curretUserLabel.Location = new System.Drawing.Point(0, 547);
            this.curretUserLabel.Name = "curretUserLabel";
            this.curretUserLabel.Size = new System.Drawing.Size(186, 23);
            this.curretUserLabel.TabIndex = 20;
            this.curretUserLabel.Text = "Label Technician";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Current User: ";
            // 
            // homeProductListView
            // 
            this.homeProductListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.homeProductListView.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeProductListView.Location = new System.Drawing.Point(27, 129);
            this.homeProductListView.Name = "homeProductListView";
            this.homeProductListView.Size = new System.Drawing.Size(946, 321);
            this.homeProductListView.TabIndex = 18;
            this.homeProductListView.UseCompatibleStateImageBehavior = false;
            this.homeProductListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CODE";
            this.columnHeader1.Width = 310;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 320;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stock";
            this.columnHeader3.Width = 310;
            // 
            // reportTypeComboBox
            // 
            this.reportTypeComboBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportTypeComboBox.FormattingEnabled = true;
            this.reportTypeComboBox.Items.AddRange(new object[] {
            "ANNUALLY",
            "MONTHLY"});
            this.reportTypeComboBox.Location = new System.Drawing.Point(261, 42);
            this.reportTypeComboBox.Name = "reportTypeComboBox";
            this.reportTypeComboBox.Size = new System.Drawing.Size(161, 31);
            this.reportTypeComboBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Generate Report By";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 593);
            this.Controls.Add(this.currentDateLabel);
            this.Controls.Add(this.curretUserLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.homeProductListView);
            this.Controls.Add(this.reportTypeComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Report";
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label currentDateLabel;
        private Label curretUserLabel;
        private Label label4;
        private ListView homeProductListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ComboBox reportTypeComboBox;
        private Label label1;
    }
}