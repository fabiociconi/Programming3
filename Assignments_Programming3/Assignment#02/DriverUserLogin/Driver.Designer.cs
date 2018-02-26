namespace DriverUserLogin
{
    partial class Driver
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
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.loginControlFabio1 = new LoginUserControlFabio.LoginControlFabio();
            this.SuspendLayout();
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(123, 106);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 1;
            this.buttonCheck.Text = "&Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(12, 151);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(33, 13);
            this.labelAnswer.TabIndex = 2;
            this.labelAnswer.Text = "Label";
            this.labelAnswer.Visible = false;
            // 
            // loginControlFabio1
            // 
            this.loginControlFabio1.Location = new System.Drawing.Point(36, 12);
            this.loginControlFabio1.Name = "loginControlFabio1";
            this.loginControlFabio1.Size = new System.Drawing.Size(200, 100);
            this.loginControlFabio1.TabIndex = 3;
            this.loginControlFabio1.Load += new System.EventHandler(this.loginControlFabio1_Load);
            // 
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 197);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.loginControlFabio1);
            this.Controls.Add(this.labelAnswer);
            this.Name = "Driver";
            this.Text = "FormDriver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelAnswer;
        private LoginUserControlFabio.LoginControlFabio loginControlFabio1;
    }
}

