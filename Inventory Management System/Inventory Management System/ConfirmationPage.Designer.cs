namespace Inventory_Management_System
{
    partial class ConfirmationPage
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
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.noButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.BackColor = System.Drawing.SystemColors.Control;
            this.currentUserLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentUserLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentUserLabel.Location = new System.Drawing.Point(79, 56);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(375, 37);
            this.currentUserLabel.TabIndex = 18;
            this.currentUserLabel.Text = "Are you sure you want to confirm?";
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.Crimson;
            this.noButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noButton.ForeColor = System.Drawing.Color.Black;
            this.noButton.Location = new System.Drawing.Point(79, 125);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(176, 72);
            this.noButton.TabIndex = 19;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = false;
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.yesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yesButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yesButton.Location = new System.Drawing.Point(290, 125);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(164, 72);
            this.yesButton.TabIndex = 20;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = false;
            // 
            // ConfirmationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 238);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.currentUserLabel);
            this.Name = "ConfirmationPage";
            this.Text = "ConfirmationPage";
            this.ResumeLayout(false);

        }

        #endregion

        private Label currentUserLabel;
        private Button noButton;
        private Button yesButton;
    }
}