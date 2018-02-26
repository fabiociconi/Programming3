//*         
//  Fabio Alexandre Ciconi
//  Student Number 300930989
//  Centennial College
//  15/05/2017
//*
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assigment_01
{
    public partial class PublishNotificationForm : Form
    {
        
        // lists to include emails and mobile phones to receive the msg
        List<string> emailToPublish = new List<string>();
        List<string> phoneToPublish = new List<string>();
        
        // create a publisher obj to call subscribe
        Publisher pb = new Publisher();      

        //initialize components and load new lists
        public PublishNotificationForm()
        {
            InitializeComponent();
            LoadLists();
        }
      
        //load lists form SubscribeForm
        private void LoadLists()
        {
            this.emailToPublish = SubscribeForm.listEmail;
            this.phoneToPublish = SubscribeForm.listPhone;
        }

        //Send message and shows summary
        private void btnPublish_Click(object sender, EventArgs e)
        {
            string textMsg = "";

            string message = textBoxMsg.Text;

            textBoxMsg.Clear();

            // MessageBox.Show("Message sent with success...");
            textMsg += "Summary: \n";
            textMsg += "Email addresses: \n";

            //send message to emails on the list
            foreach (var item in emailToPublish)
            {
                SendViaEmail em = new SendViaEmail(item);
                em.Subscribe(pb);
                pb.publishmsg(message);
                textMsg += item + "\n";
            }
            textMsg += "Mobile numbers: \n";

            //send message to the mobile phones in the list
            foreach (var mobile in phoneToPublish)
            {
                SendViaMobile mb = new SendViaMobile(mobile);
                mb.Subscribe(pb);
                pb.publishmsg(message);
                textMsg += mobile + "\n";
            }
            //show summary
            MessageBox.Show(textMsg);
        }
        //Close the window
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PublishNotificationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
