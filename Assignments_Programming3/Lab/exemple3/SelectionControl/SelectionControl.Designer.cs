namespace SelectionControl
{
    partial class SelectionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkOption2 = new System.Windows.Forms.CheckBox();
            this.chkOption1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkOption2);
            this.groupBox1.Controls.Add(this.chkOption1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(93, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select options";
            // 
            // chkOption2
            // 
            this.chkOption2.AutoSize = true;
            this.chkOption2.Location = new System.Drawing.Point(117, 163);
            this.chkOption2.Name = "chkOption2";
            this.chkOption2.Size = new System.Drawing.Size(191, 46);
            this.chkOption2.TabIndex = 1;
            this.chkOption2.Text = "Option 2";
            this.chkOption2.UseVisualStyleBackColor = true;
            this.chkOption2.CheckedChanged += new System.EventHandler(this.chkOption2_CheckedChanged);
            // 
            // chkOption1
            // 
            this.chkOption1.AutoSize = true;
            this.chkOption1.Location = new System.Drawing.Point(117, 82);
            this.chkOption1.Name = "chkOption1";
            this.chkOption1.Size = new System.Drawing.Size(191, 46);
            this.chkOption1.TabIndex = 0;
            this.chkOption1.Text = "Option 1";
            this.chkOption1.UseVisualStyleBackColor = true;
            this.chkOption1.CheckedChanged += new System.EventHandler(this.chkOption1_CheckedChanged);
            // 
            // SelectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "SelectionControl";
            this.Size = new System.Drawing.Size(635, 462);
            this.Load += new System.EventHandler(this.SelectionControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkOption2;
        private System.Windows.Forms.CheckBox chkOption1;
    }
}
