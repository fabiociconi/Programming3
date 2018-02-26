using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DataBaseLibrary_Test2;//tabelas que criei

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private AMSEntities dbcontext = new AMSEntities();

        public static string loginInformation;
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCard.Text = "";
            textBoxPassword.Text = "";

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            dbcontext.Login.Load();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UserInformation info = new UserInformation(textBoxCard.Text, textBoxPassword.Text);

            var Userinfo = from User in dbcontext.Login
                           select User;


            if ((info.UserID == "") || (info.Password == ""))
            {
                MessageBox.Show("Please Input Card Number and Pssaword");
            }
            else
                foreach (var item in Userinfo)
                {
                    if ((info.UserID == item.AccessID) && (info.Password == item.Password))
                    {
                        loginInformation = item.AccessID;
                        MakePayment makePayment = new MakePayment();
                        makePayment.Show();
                        this.Visible = false;//esconde esta janela
                        return;
                    }
                }
            MessageBox.Show("We couldn't find the user/password in the databasse ");
            return;
        }
    }
}

