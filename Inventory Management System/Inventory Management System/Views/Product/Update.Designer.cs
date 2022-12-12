namespace Inventory_Management_System.Views.Product
{
    partial class Update
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
            this.label1 = new System.Windows.Forms.Label();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButtonUpdate = new System.Windows.Forms.Button();
            this.errorLabelUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many labels have you taken?";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(99, 90);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(101, 27);
            this.qtyTextBox.TabIndex = 1;
            this.qtyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtyTextBox_KeyPress);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(161, 161);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(78, 29);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "SUBMIT";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButtonUpdate
            // 
            this.cancelButtonUpdate.Location = new System.Drawing.Point(48, 161);
            this.cancelButtonUpdate.Name = "cancelButtonUpdate";
            this.cancelButtonUpdate.Size = new System.Drawing.Size(78, 29);
            this.cancelButtonUpdate.TabIndex = 3;
            this.cancelButtonUpdate.Text = "CANCEL";
            this.cancelButtonUpdate.UseVisualStyleBackColor = true;
            this.cancelButtonUpdate.Click += new System.EventHandler(this.cancelButtonUpdate_Click);
            // 
            // errorLabelUpdate
            // 
            this.errorLabelUpdate.AutoSize = true;
            this.errorLabelUpdate.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLabelUpdate.ForeColor = System.Drawing.Color.Red;
            this.errorLabelUpdate.Location = new System.Drawing.Point(114, 129);
            this.errorLabelUpdate.Name = "errorLabelUpdate";
            this.errorLabelUpdate.Size = new System.Drawing.Size(0, 15);
            this.errorLabelUpdate.TabIndex = 4;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 217);
            this.Controls.Add(this.errorLabelUpdate);
            this.Controls.Add(this.cancelButtonUpdate);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.qtyTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox qtyTextBox;
        private Button updateButton;
        private Button cancelButtonUpdate;
        private Label errorLabelUpdate;
    }
}