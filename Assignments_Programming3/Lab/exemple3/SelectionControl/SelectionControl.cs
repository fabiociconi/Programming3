using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectionControl
{
    public partial class SelectionControl : UserControl
    {
        public SelectionControl()
        {
            InitializeComponent();
        }
        private string option1, option2;

        public string Option1
        {
            get { return option1; }
            set { option1 = value; }
        }
        
        private void chkOption1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOption1.Checked == true)
                option1 = chkOption1.Text;
            else
                option1 = "";
        }
        public string Option2
        {
            get { return option2; }
            set { option2 = value; }
        }
        private void chkOption2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOption2.Checked == true)
                option2 = chkOption2.Text;
            else
                option2 = "";
        }

        private void SelectionControl_Load(object sender, EventArgs e)
        {

        }
    }
}
