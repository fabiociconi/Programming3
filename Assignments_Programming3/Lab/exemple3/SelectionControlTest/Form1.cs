using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectionControlTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string output="";
            if (!String.IsNullOrEmpty(selectionControl1.Option1))
                output = selectionControl1.Option1;
            if (!String.IsNullOrEmpty(selectionControl1.Option2))
                output+= selectionControl1.Option2;
            MessageBox.Show(output);
        }
    }
}
