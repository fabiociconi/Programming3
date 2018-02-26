using System;
using System.Collections.Generic;
using System.ComponentModel;
/*
 * Author       : Raveena Tayal
 * Student ID   : 300813330
 * Last Modified: 1/23/2016
 */

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_Assignment01
{
    public partial class PublishForm : Form
    {

        //List to hold email addresses of subscribers
        List<string> emailList = new List<string>();

        //List to hold mobile phones of subscribers
        List<string> mobileList = new List<string>();

        ManagerForm managerForm;
        

        public PublishForm()
        {
            InitializeComponent();
            
        }

        //Populate email and mobile lists from manager form
        public void populateLists()
        {
            this.emailList = managerForm.emailList;
            this.mobileList = managerForm.mobileList;
        }

        //Dispose the form when cancel button is clicked
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Display list of subscribers when publish button is clicked
        private void publishButton_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text;
            string text="";
            message = message.Trim();

            //Publish the message if it is not empty
            if(message=="")
            {
                MessageBox.Show("Please enter a message to publish!!!");
            }
            else
            {
                text += "The message \"" + message + "\" has been sent to following: \n";
                text += "Email addresses: \n";
                
                //Iterate through email list
                foreach(var email in emailList)
                {
                    text += email + "\n";
                }
                text += "Mobile numbers: \n";

                //Iterate through mobile list
                foreach (var mobile in mobileList)
                {
                    text += mobile + "\n";
                }
                MessageBox.Show(text);
            }
        }

        //When Publish form is the active form, populate the lists 
        private void PublishForm_Activated(object sender, EventArgs e)
        {
            this.managerForm = (ManagerForm)this.Owner;
            populateLists();
        }
    }
}
