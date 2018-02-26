using System;
using System.Windows.Forms;

namespace LoginUserControlFabio
{
    public partial class LoginControlFabio: UserControl
    {
        public LoginControlFabio()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        public string UserField
        {
            get
            {
                return textBoxUser.Text;
            }
        }

        public string PasswordField
        {
            get
            {
                return textBoxPassword.Text;
            }
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
