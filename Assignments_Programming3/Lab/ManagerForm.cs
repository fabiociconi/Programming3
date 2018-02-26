/*
 * Author       : Raveena Tayal
 * Student ID   : 300813330
 * Last Modified: 1/23/2016
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_Assignment01
{
    public partial class ManagerForm : Form
    {

        //List to hold email addresses of subscribers
        public List<string> emailList = new List<string>();

        //List to hold mobile phones of subscribers
        public List<string> mobileList = new List<string>();

        //Declare Delegate
        public delegate void PublishMessageDel();

        //Declare an instance variable which is a Delegate object 
        public event PublishMessageDel publishmsg = delegate { };

        ManagerForm manager;
        SubscribeForm subForm;
        PublishForm pubForm;

        public ManagerForm()
        {
            InitializeComponent();
            manager = this;
            
        }

        //Event handler for click event of exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            Application.Exit();
        }

        //Show subscribe form when manage subscription button is clicked
        private void subscriptionButton_Click(object sender, EventArgs e)
        {
            this.manager = (ManagerForm)ActiveForm;
            subForm = new SubscribeForm();
            subForm.Owner = this.manager; 
            subForm.Show();
        }

        //Show Publish form when manage publish button is clicked
        private void publishButton_Click(object sender, EventArgs e)
        {
            PublishMessage();
            
            this.manager = (ManagerForm)ActiveForm;
            pubForm = new PublishForm();
            pubForm.Owner = this.manager;
            pubForm.Show();
            
        }

        //Invoke the delegate
        public void PublishMessage()
        {
           this.manager.publishmsg.Invoke();
        }
    }
}
