namespace Fabio_Ciconi_Test03_Sec003_Ex01
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
            this.groupBoxLeft = new System.Windows.Forms.GroupBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSal = new System.Windows.Forms.TextBox();
            this.textBoxDepto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxRight = new System.Windows.Forms.GroupBox();
            this.buttonAvg = new System.Windows.Forms.Button();
            this.buttonGT50 = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.listBoxInt = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelte = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxLeft.SuspendLayout();
            this.groupBoxRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLeft
            // 
            this.groupBoxLeft.Controls.Add(this.textBoxID);
            this.groupBoxLeft.Controls.Add(this.textBoxName);
            this.groupBoxLeft.Controls.Add(this.buttonAdd);
            this.groupBoxLeft.Controls.Add(this.textBoxSal);
            this.groupBoxLeft.Controls.Add(this.buttonDelte);
            this.groupBoxLeft.Controls.Add(this.buttonSearch);
            this.groupBoxLeft.Controls.Add(this.textBoxDepto);
            this.groupBoxLeft.Controls.Add(this.buttonDisplay);
            this.groupBoxLeft.Controls.Add(this.label2);
            this.groupBoxLeft.Controls.Add(this.buttonMax);
            this.groupBoxLeft.Controls.Add(this.label3);
            this.groupBoxLeft.Controls.Add(this.label4);
            this.groupBoxLeft.Controls.Add(this.label5);
            this.groupBoxLeft.Location = new System.Drawing.Point(30, 55);
            this.groupBoxLeft.Name = "groupBoxLeft";
            this.groupBoxLeft.Size = new System.Drawing.Size(309, 189);
            this.groupBoxLeft.TabIndex = 0;
            this.groupBoxLeft.TabStop = false;
            this.groupBoxLeft.Text = "Employee Info-Sorted Dictionary";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(100, 29);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(100, 58);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxSal
            // 
            this.textBoxSal.Location = new System.Drawing.Point(100, 87);
            this.textBoxSal.Name = "textBoxSal";
            this.textBoxSal.Size = new System.Drawing.Size(100, 20);
            this.textBoxSal.TabIndex = 9;
            // 
            // textBoxDepto
            // 
            this.textBoxDepto.Location = new System.Drawing.Point(100, 118);
            this.textBoxDepto.Name = "textBoxDepto";
            this.textBoxDepto.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepto.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name of Employee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yearly Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Department";
            // 
            // groupBoxRight
            // 
            this.groupBoxRight.Controls.Add(this.buttonAvg);
            this.groupBoxRight.Controls.Add(this.buttonGT50);
            this.groupBoxRight.Controls.Add(this.buttonSum);
            this.groupBoxRight.Controls.Add(this.buttonGenerate);
            this.groupBoxRight.Controls.Add(this.listBoxInt);
            this.groupBoxRight.Location = new System.Drawing.Point(365, 53);
            this.groupBoxRight.Name = "groupBoxRight";
            this.groupBoxRight.Size = new System.Drawing.Size(286, 189);
            this.groupBoxRight.TabIndex = 1;
            this.groupBoxRight.TabStop = false;
            this.groupBoxRight.Text = "List of Vlues - Functional Programming";
            this.groupBoxRight.Enter += new System.EventHandler(this.groupBoxRight_Enter);
            // 
            // buttonAvg
            // 
            this.buttonAvg.Location = new System.Drawing.Point(96, 137);
            this.buttonAvg.Name = "buttonAvg";
            this.buttonAvg.Size = new System.Drawing.Size(75, 23);
            this.buttonAvg.TabIndex = 10;
            this.buttonAvg.Text = "Average";
            this.buttonAvg.UseVisualStyleBackColor = true;
            this.buttonAvg.Click += new System.EventHandler(this.buttonAvg_Click);
            // 
            // buttonGT50
            // 
            this.buttonGT50.Location = new System.Drawing.Point(96, 108);
            this.buttonGT50.Name = "buttonGT50";
            this.buttonGT50.Size = new System.Drawing.Size(75, 23);
            this.buttonGT50.TabIndex = 9;
            this.buttonGT50.Text = "Filter > 50";
            this.buttonGT50.UseVisualStyleBackColor = true;
            this.buttonGT50.Click += new System.EventHandler(this.buttonGT50_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(96, 79);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(75, 23);
            this.buttonSum.TabIndex = 8;
            this.buttonSum.Text = "Sum";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(96, 50);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 7;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // listBoxInt
            // 
            this.listBoxInt.FormattingEnabled = true;
            this.listBoxInt.Location = new System.Drawing.Point(6, 29);
            this.listBoxInt.Name = "listBoxInt";
            this.listBoxInt.Size = new System.Drawing.Size(48, 147);
            this.listBoxInt.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(206, 24);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelte
            // 
            this.buttonDelte.Location = new System.Drawing.Point(206, 53);
            this.buttonDelte.Name = "buttonDelte";
            this.buttonDelte.Size = new System.Drawing.Size(75, 23);
            this.buttonDelte.TabIndex = 1;
            this.buttonDelte.Text = "Delete";
            this.buttonDelte.UseVisualStyleBackColor = true;
            this.buttonDelte.Click += new System.EventHandler(this.buttonDelte_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(206, 82);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(206, 111);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(75, 23);
            this.buttonDisplay.TabIndex = 3;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(206, 140);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(75, 23);
            this.buttonMax.TabIndex = 4;
            this.buttonMax.Text = "Max Salary";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(30, 324);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(631, 66);
            this.textBoxOutput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Output:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.groupBoxRight);
            this.Controls.Add(this.groupBoxLeft);
            this.Name = "Form1";
            this.Text = "TEST 02 - COMP212- Sec003";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxLeft.ResumeLayout(false);
            this.groupBoxLeft.PerformLayout();
            this.groupBoxRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLeft;
        private System.Windows.Forms.GroupBox groupBoxRight;
        private System.Windows.Forms.Button buttonAvg;
        private System.Windows.Forms.Button buttonGT50;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ListBox listBoxInt;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelte;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSal;
        private System.Windows.Forms.TextBox textBoxDepto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

