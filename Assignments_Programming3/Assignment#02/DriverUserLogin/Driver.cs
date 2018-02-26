using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverUserLogin
{
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            
            labelAnswer.Text = "User Name : "+ loginControlFabio1.UserField + "\nPassword : " + loginControlFabio1.PasswordField;
            labelAnswer.Visible = true;
           
        }

        private void loginControlFabio1_Load(object sender, EventArgs e)
        {

        }
    }
}
