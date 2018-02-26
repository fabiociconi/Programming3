namespace Assigment_2
{
    partial class Calculator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelBeverages = new System.Windows.Forms.Label();
            this.labelAppetizer = new System.Windows.Forms.Label();
            this.labelDessert = new System.Windows.Forms.Label();
            this.labelMainCourse = new System.Windows.Forms.Label();
            this.comboBoxBeverages = new System.Windows.Forms.ComboBox();
            this.comboBoxMainCourse = new System.Windows.Forms.ComboBox();
            this.comboBoxAppetizer = new System.Windows.Forms.ComboBox();
            this.comboBoxDessert = new System.Windows.Forms.ComboBox();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBeverages
            // 
            this.labelBeverages.AutoSize = true;
            this.labelBeverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeverages.ForeColor = System.Drawing.Color.Navy;
            this.labelBeverages.Location = new System.Drawing.Point(12, 29);
            this.labelBeverages.Name = "labelBeverages";
            this.labelBeverages.Size = new System.Drawing.Size(106, 25);
            this.labelBeverages.TabIndex = 0;
            this.labelBeverages.Text = "Beverages";
            // 
            // labelAppetizer
            // 
            this.labelAppetizer.AutoSize = true;
            this.labelAppetizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppetizer.ForeColor = System.Drawing.Color.Navy;
            this.labelAppetizer.Location = new System.Drawing.Point(12, 101);
            this.labelAppetizer.Name = "labelAppetizer";
            this.labelAppetizer.Size = new System.Drawing.Size(95, 25);
            this.labelAppetizer.TabIndex = 1;
            this.labelAppetizer.Text = "Appetizer";
            // 
            // labelDessert
            // 
            this.labelDessert.AutoSize = true;
            this.labelDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDessert.ForeColor = System.Drawing.Color.Navy;
            this.labelDessert.Location = new System.Drawing.Point(12, 137);
            this.labelDessert.Name = "labelDessert";
            this.labelDessert.Size = new System.Drawing.Size(79, 25);
            this.labelDessert.TabIndex = 3;
            this.labelDessert.Text = "Dessert";
            // 
            // labelMainCourse
            // 
            this.labelMainCourse.AutoSize = true;
            this.labelMainCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainCourse.ForeColor = System.Drawing.Color.Navy;
            this.labelMainCourse.Location = new System.Drawing.Point(12, 65);
            this.labelMainCourse.Name = "labelMainCourse";
            this.labelMainCourse.Size = new System.Drawing.Size(124, 25);
            this.labelMainCourse.TabIndex = 2;
            this.labelMainCourse.Text = "Main Course";
            // 
            // comboBoxBeverages
            // 
            this.comboBoxBeverages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBeverages.FormattingEnabled = true;
            this.comboBoxBeverages.Location = new System.Drawing.Point(185, 32);
            this.comboBoxBeverages.Name = "comboBoxBeverages";
            this.comboBoxBeverages.Size = new System.Drawing.Size(203, 21);
            this.comboBoxBeverages.TabIndex = 4;
            this.comboBoxBeverages.SelectedIndexChanged += new System.EventHandler(this.comboBoxBeverages_SelectedIndexChanged);
            // 
            // comboBoxMainCourse
            // 
            this.comboBoxMainCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMainCourse.FormattingEnabled = true;
            this.comboBoxMainCourse.Location = new System.Drawing.Point(185, 69);
            this.comboBoxMainCourse.Name = "comboBoxMainCourse";
            this.comboBoxMainCourse.Size = new System.Drawing.Size(203, 21);
            this.comboBoxMainCourse.TabIndex = 5;
            this.comboBoxMainCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxMainCourse_SelectedIndexChanged);
            // 
            // comboBoxAppetizer
            // 
            this.comboBoxAppetizer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAppetizer.FormattingEnabled = true;
            this.comboBoxAppetizer.Location = new System.Drawing.Point(185, 106);
            this.comboBoxAppetizer.Name = "comboBoxAppetizer";
            this.comboBoxAppetizer.Size = new System.Drawing.Size(203, 21);
            this.comboBoxAppetizer.TabIndex = 6;
            this.comboBoxAppetizer.SelectedIndexChanged += new System.EventHandler(this.comboBoxAppetizer_SelectedIndexChanged);
            // 
            // comboBoxDessert
            // 
            this.comboBoxDessert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDessert.FormattingEnabled = true;
            this.comboBoxDessert.Location = new System.Drawing.Point(185, 143);
            this.comboBoxDessert.Name = "comboBoxDessert";
            this.comboBoxDessert.Size = new System.Drawing.Size(203, 21);
            this.comboBoxDessert.TabIndex = 7;
            this.comboBoxDessert.SelectedIndexChanged += new System.EventHandler(this.comboBoxDessert_SelectedIndexChanged);
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Location = new System.Drawing.Point(459, 29);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(132, 40);
            this.buttonCheckOut.TabIndex = 8;
            this.buttonCheckOut.Text = "Check Out";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(459, 454);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(132, 40);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(459, 132);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(132, 40);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTotal.ForeColor = System.Drawing.Color.Navy;
            this.labelSubTotal.Location = new System.Drawing.Point(398, 352);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(92, 25);
            this.labelSubTotal.TabIndex = 12;
            this.labelSubTotal.Text = "SubTotal";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTax.ForeColor = System.Drawing.Color.Navy;
            this.labelTax.Location = new System.Drawing.Point(398, 384);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(101, 25);
            this.labelTax.TabIndex = 13;
            this.labelTax.Text = "Tax(HST)";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Navy;
            this.labelTotal.Location = new System.Drawing.Point(398, 416);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(56, 25);
            this.labelTotal.TabIndex = 14;
            this.labelTotal.Text = "Total";
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Location = new System.Drawing.Point(496, 354);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.ReadOnly = true;
            this.textBoxSubTotal.Size = new System.Drawing.Size(124, 20);
            this.textBoxSubTotal.TabIndex = 15;
            this.textBoxSubTotal.Text = "$0.00";
            this.textBoxSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTax
            // 
            this.textBoxTax.Location = new System.Drawing.Point(496, 385);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.Size = new System.Drawing.Size(124, 20);
            this.textBoxTax.TabIndex = 16;
            this.textBoxTax.Text = "13";
            this.textBoxTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(496, 416);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(124, 20);
            this.textBoxTotal.TabIndex = 17;
            this.textBoxTotal.Text = "$0.00";
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assigment_2.Properties.Resources.restaurant_icon_png_7;
            this.pictureBox1.Location = new System.Drawing.Point(94, 353);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelName.Location = new System.Drawing.Point(97, 469);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(136, 25);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Restaurant Bill";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 502);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownButtonWidth = 0;
            this.toolStripSplitButton1.Image = global::Assigment_2.Properties.Resources.restaurant_icon_png_7;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(21, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel1.Text = "Restaurant Bill";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToResizeColumns = false;
            this.dataGridViewResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewResult.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewResult.Location = new System.Drawing.Point(12, 179);
            this.dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewResult.RowTemplate.ReadOnly = true;
            this.dataGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResult.Size = new System.Drawing.Size(579, 150);
            this.dataGridViewResult.TabIndex = 21;
            this.dataGridViewResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResult_CellContentClick);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(459, 77);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(132, 39);
            this.buttonRemove.TabIndex = 22;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 524);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxTax);
            this.Controls.Add(this.textBoxSubTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelSubTotal);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.comboBoxDessert);
            this.Controls.Add(this.comboBoxAppetizer);
            this.Controls.Add(this.comboBoxMainCourse);
            this.Controls.Add(this.comboBoxBeverages);
            this.Controls.Add(this.labelDessert);
            this.Controls.Add(this.labelMainCourse);
            this.Controls.Add(this.labelAppetizer);
            this.Controls.Add(this.labelBeverages);
            this.Name = "Calculator";
            this.Text = "Restaurant Bill Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBeverages;
        private System.Windows.Forms.Label labelAppetizer;
        private System.Windows.Forms.Label labelDessert;
        private System.Windows.Forms.Label labelMainCourse;
        private System.Windows.Forms.ComboBox comboBoxBeverages;
        private System.Windows.Forms.ComboBox comboBoxMainCourse;
        private System.Windows.Forms.ComboBox comboBoxAppetizer;
        private System.Windows.Forms.ComboBox comboBoxDessert;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Button buttonRemove;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}