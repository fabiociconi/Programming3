using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//use the library namespace
using MyLibrary;

namespace MyLibraryTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            MyClass myObj = new MyClass();

            MessageBox.Show(myObj.MyMethod(tbMessage.Text, tbName.Text));

        }
    }
}
