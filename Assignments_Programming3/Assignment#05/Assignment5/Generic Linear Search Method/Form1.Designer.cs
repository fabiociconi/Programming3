namespace Generic_Linear_Search_Method
{
    partial class Form1
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
            this.TextBoxIntegers = new System.Windows.Forms.TextBox();
            this.TextBoxDouble = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxSeachInteger = new System.Windows.Forms.TextBox();
            this.ButtonRandomIntegers = new System.Windows.Forms.Button();
            this.ButtonRandomDoubles = new System.Windows.Forms.Button();
            this.TextBoxSeachDouble = new System.Windows.Forms.TextBox();
            this.labelInteger = new System.Windows.Forms.Label();
            this.labelDouble = new System.Windows.Forms.Label();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.labelResultInteger = new System.Windows.Forms.Label();
            this.labelResultDouble = new System.Windows.Forms.Label();
            this.labelWarning = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxIntegers
            // 
            this.TextBoxIntegers.Location = new System.Drawing.Point(5, 12);
            this.TextBoxIntegers.Name = "TextBoxIntegers";
            this.TextBoxIntegers.ReadOnly = true;
            this.TextBoxIntegers.Size = new System.Drawing.Size(225, 20);
            this.TextBoxIntegers.TabIndex = 0;
            // 
            // TextBoxDouble
            // 
            this.TextBoxDouble.Location = new System.Drawing.Point(5, 38);
            this.TextBoxDouble.Name = "TextBoxDouble";
            this.TextBoxDouble.ReadOnly = true;
            this.TextBoxDouble.Size = new System.Drawing.Size(225, 20);
            this.TextBoxDouble.TabIndex = 1;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(98, 167);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "&Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxSeachInteger
            // 
            this.TextBoxSeachInteger.Location = new System.Drawing.Point(46, 64);
            this.TextBoxSeachInteger.Name = "TextBoxSeachInteger";
            this.TextBoxSeachInteger.Size = new System.Drawing.Size(52, 20);
            this.TextBoxSeachInteger.TabIndex = 3;
            // 
            // ButtonRandomIntegers
            // 
            this.ButtonRandomIntegers.Location = new System.Drawing.Point(236, 12);
            this.ButtonRandomIntegers.Name = "ButtonRandomIntegers";
            this.ButtonRandomIntegers.Size = new System.Drawing.Size(103, 23);
            this.ButtonRandomIntegers.TabIndex = 4;
            this.ButtonRandomIntegers.Text = "Random Integers";
            this.ButtonRandomIntegers.UseVisualStyleBackColor = true;
            this.ButtonRandomIntegers.Click += new System.EventHandler(this.ButtonRandomIntegers_Click);
            // 
            // ButtonRandomDoubles
            // 
            this.ButtonRandomDoubles.Location = new System.Drawing.Point(236, 38);
            this.ButtonRandomDoubles.Name = "ButtonRandomDoubles";
            this.ButtonRandomDoubles.Size = new System.Drawing.Size(103, 23);
            this.ButtonRandomDoubles.TabIndex = 5;
            this.ButtonRandomDoubles.Text = "Random Doubles";
            this.ButtonRandomDoubles.UseVisualStyleBackColor = true;
            this.ButtonRandomDoubles.Click += new System.EventHandler(this.ButtonRandomDoubles_Click);
            // 
            // TextBoxSeachDouble
            // 
            this.TextBoxSeachDouble.Location = new System.Drawing.Point(46, 90);
            this.TextBoxSeachDouble.Name = "TextBoxSeachDouble";
            this.TextBoxSeachDouble.Size = new System.Drawing.Size(52, 20);
            this.TextBoxSeachDouble.TabIndex = 6;
            // 
            // labelInteger
            // 
            this.labelInteger.AutoSize = true;
            this.labelInteger.Location = new System.Drawing.Point(1, 67);
            this.labelInteger.Name = "labelInteger";
            this.labelInteger.Size = new System.Drawing.Size(43, 13);
            this.labelInteger.TabIndex = 7;
            this.labelInteger.Text = "Integer:";
            // 
            // labelDouble
            // 
            this.labelDouble.AutoSize = true;
            this.labelDouble.Location = new System.Drawing.Point(1, 93);
            this.labelDouble.Name = "labelDouble";
            this.labelDouble.Size = new System.Drawing.Size(44, 13);
            this.labelDouble.TabIndex = 8;
            this.labelDouble.Text = "Double:";
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(199, 167);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 23);
            this.ButtonClear.TabIndex = 9;
            this.ButtonClear.Text = "&Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // labelResultInteger
            // 
            this.labelResultInteger.AutoSize = true;
            this.labelResultInteger.ForeColor = System.Drawing.Color.Red;
            this.labelResultInteger.Location = new System.Drawing.Point(104, 67);
            this.labelResultInteger.Name = "labelResultInteger";
            this.labelResultInteger.Size = new System.Drawing.Size(29, 13);
            this.labelResultInteger.TabIndex = 10;
            this.labelResultInteger.Text = "label";
            this.labelResultInteger.Visible = false;
            // 
            // labelResultDouble
            // 
            this.labelResultDouble.AutoSize = true;
            this.labelResultDouble.ForeColor = System.Drawing.Color.Red;
            this.labelResultDouble.Location = new System.Drawing.Point(104, 97);
            this.labelResultDouble.Name = "labelResultDouble";
            this.labelResultDouble.Size = new System.Drawing.Size(35, 13);
            this.labelResultDouble.TabIndex = 11;
            this.labelResultDouble.Text = "label2";
            this.labelResultDouble.Visible = false;
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(12, 138);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(47, 13);
            this.labelWarning.TabIndex = 12;
            this.labelWarning.Text = "Warning";
            this.labelWarning.Visible = false;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(155, 212);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 13;
            this.ButtonExit.Text = "&Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(351, 261);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.labelResultDouble);
            this.Controls.Add(this.labelResultInteger);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.labelDouble);
            this.Controls.Add(this.labelInteger);
            this.Controls.Add(this.TextBoxSeachDouble);
            this.Controls.Add(this.ButtonRandomDoubles);
            this.Controls.Add(this.ButtonRandomIntegers);
            this.Controls.Add(this.TextBoxSeachInteger);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.TextBoxDouble);
            this.Controls.Add(this.TextBoxIntegers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generic Linear Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxIntegers;
        private System.Windows.Forms.TextBox TextBoxDouble;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox TextBoxSeachInteger;
        private System.Windows.Forms.Button ButtonRandomIntegers;
        private System.Windows.Forms.Button ButtonRandomDoubles;
        private System.Windows.Forms.TextBox TextBoxSeachDouble;
        private System.Windows.Forms.Label labelInteger;
        private System.Windows.Forms.Label labelDouble;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Label labelResultInteger;
        private System.Windows.Forms.Label labelResultDouble;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.Button ButtonExit;
    }
}

