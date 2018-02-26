//*         
//  Fabio Alexandre Ciconi
//  Student Number 300930989
//  Centennial College
//  15/05/2017
//*
using System;
using System.Windows.Forms;

namespace Assigment_01
{
    public partial class NotificationManagerForm : Form
    {
        //Initialize Component
        public NotificationManagerForm()
        {
            InitializeComponent();
        }

        //Close window
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        // show Subscribe and Unsubscribe form
        private void btnManageSub_Click(object sender, EventArgs e)
        {

            SubscribeForm sub = new SubscribeForm();
            sub.Show();

        }
        //Show Publish Form
        private void btnPublishNot_Click(object sender, EventArgs e)
        {

            PublishNotificationForm pub = new PublishNotificationForm();
            pub.Show();
        }

        private void NotificationManagerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
