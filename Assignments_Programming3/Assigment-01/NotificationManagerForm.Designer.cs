namespace Assigment_01
{
    partial class NotificationManagerForm
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
            this.btnManageSub = new System.Windows.Forms.Button();
            this.btnPublishNot = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageSub
            // 
            this.btnManageSub.Location = new System.Drawing.Point(27, 72);
            this.btnManageSub.Name = "btnManageSub";
            this.btnManageSub.Size = new System.Drawing.Size(130, 40);
            this.btnManageSub.TabIndex = 0;
            this.btnManageSub.Text = "Manage Subscription";
            this.btnManageSub.UseVisualStyleBackColor = true;
            this.btnManageSub.Click += new System.EventHandler(this.btnManageSub_Click);
            // 
            // btnPublishNot
            // 
            this.btnPublishNot.Location = new System.Drawing.Point(186, 72);
            this.btnPublishNot.Name = "btnPublishNot";
            this.btnPublishNot.Size = new System.Drawing.Size(130, 40);
            this.btnPublishNot.TabIndex = 1;
            this.btnPublishNot.Text = "Publish Notification";
            this.btnPublishNot.UseVisualStyleBackColor = true;
            this.btnPublishNot.Click += new System.EventHandler(this.btnPublishNot_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(351, 72);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // NotificationManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(518, 197);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPublishNot);
            this.Controls.Add(this.btnManageSub);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotificationManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notification ManagerForm";
            this.Load += new System.EventHandler(this.NotificationManagerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageSub;
        private System.Windows.Forms.Button btnPublishNot;
        private System.Windows.Forms.Button btnExit;
     

    }

}