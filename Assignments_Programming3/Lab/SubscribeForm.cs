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
using System.Text.RegularExpressions;

namespace COMP212_Assignment01
{
    public partial class SubscribeForm : Form
    {

        //INSTANCE VARIABLES
        string email="", mobile="";
        bool emailChecked = false, mobileChecked = false;
        bool isValidEmail = false, isValidMobile = false;
        bool emailExist = false, mobileExist =false;
        bool emailNotFound=false, mobileNotFound = false;

        public ManagerForm manager = new ManagerForm();


        SendViaEmail send2Email;
        SendViaMobile send2Mobile;

        public SubscribeForm()
        {          
            InitializeComponent();
        }

        private void emailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Enable email textbox only if the email checkbox is checked
            emailTextBox.Enabled = emailChecked=(emailCheckBox.Checked) ? true : false;
        }

        private void mobileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Enable mobile textbox only if the mobile checkbox is checked
            mobileTextBox.Enabled = mobileChecked=(mobileCheckBox.Checked) ? true : false;
        }

        //Subscribe for a notification if subscribe button is clicked
        private void subscribeButton_Click(object sender, EventArgs e)
        {
            string message="";
            manager.PublishMessage();

            //Check if none of the checkboxes are checked
            sendEmailMobile("Subscription");

            //Check if the email already exists
            if (emailChecked)
            {
                if(manager.emailList.Contains(email))
                {
                    MessageBox.Show("The email already exists");
                    emailExist = true;
                }
            }

            //Check if the mobile already exists
            if (mobileChecked)
            {
                if (manager.mobileList.Contains(mobile))
                {
                    MessageBox.Show("The phone number already exists");
                    mobileExist = true;
                }
            }

            //If the email and/or mobile is valid and new, add it to the list by subscribing
            if (!mobileExist && !emailExist)
            {
                if (emailChecked && mobileChecked)
                {
                    if (isValidEmail && isValidMobile)
                    {
                        send2Email = new SendViaEmail(email);
                        send2Email.Subscribe(manager);
                        send2Mobile = new SendViaMobile(mobile);
                        send2Mobile.Subscribe(manager);
                        message = "Subscription successful!!!";
                    }
                    else
                    {
                        message = "Please check your mobile/ email address";
                    }

                }
                else if (emailChecked && !mobileChecked)
                {
                    if (isValidEmail)
                    {
                        message = "Subscription successful!!!";
                        send2Email = new SendViaEmail(email);
                        send2Email.Subscribe(manager);
                    }
                    else
                    {
                        message = "Please check your email address";
                    }
                }
                else if (mobileChecked && !emailChecked)
                {
                    if (isValidMobile)
                    {
                        message = "Subscription successful!!!";
                        send2Mobile = new SendViaMobile(mobile);
                        send2Mobile.Subscribe(manager);
                    }
                    else
                    {
                        message = "Please check your mobile number";
                    }
                }
                if (message != "")
                    MessageBox.Show(message);
            }
        }

        //Unsubscribe for a notification if unsubscribe button is clicked
        private void unsubscribeButton_Click(object sender, EventArgs e)
        {
            string message = "";
            manager.PublishMessage();

            ////Check if none of the checkboxes are checked
            sendEmailMobile("Unsubscription");

            //Check if the email doesnot exist for unsubscription
            if (emailChecked)
            {
                if(!manager.emailList.Contains(email))
                {
                    MessageBox.Show("The email has not subscribed");
                    emailNotFound = true;
                }
            }

            //Check if the mobile doesnot exist for unsubscription
            if (mobileChecked)
            {
                if (!manager.mobileList.Contains(mobile))
                {
                    MessageBox.Show("The phone number has not subscribed");
                    mobileNotFound = true;
                }
            }

            //Unsubscribe if email and/or mobile are valid and exist in the list
            if (!emailNotFound && !mobileNotFound)
            {
                if (emailChecked && mobileChecked)
                {
                    if (isValidEmail && isValidMobile)
                    {
                        message = "Unsubscription successful!!!";
                        send2Email = new SendViaEmail(email);
                        send2Email.Unsubscribe(manager);
                        send2Mobile = new SendViaMobile(mobile);
                        send2Mobile.Unsubscribe(manager);
                    }
                    else
                    {
                        message = "Please check your mobile/ email address";
                    }

                }
                else if (emailChecked && !mobileChecked)
                {
                    if (isValidEmail)
                    {
                        message = "Unsubscription successful!!!";
                        send2Email = new SendViaEmail(email);
                        send2Email.Unsubscribe(manager);
                    }
                    else
                    {
                        message = "Please check your email address";
                    }
                }
                else if (mobileChecked && !emailChecked)
                {
                    if (isValidMobile)
                    {
                        message = "Unsubscription successful!!!";
                        send2Mobile = new SendViaMobile(mobile);
                        send2Mobile.Unsubscribe(manager);
                    }
                    else
                    {
                        message = "Please check your mobile number";
                    }
                }
                if (message != "")
                    MessageBox.Show(message);
            }
        }

        //Dispose the form when cancel button is clicked
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Assign email and mobile values based on the checkboxes that are checked
        private void sendEmailMobile(string subscribe)
        {            
            if (emailChecked)
            {
                email = emailTextBox.Text;
                isValidEmail = validateEmail(email);
            }
            if (mobileChecked)
            {
                mobile = mobileTextBox.Text;
                isValidMobile = validateMobile(mobile);
            }
            if(!emailChecked && !mobileChecked)
            {
                MessageBox.Show("Enter atleast an email or mobile number for " + subscribe);
            }
        }

        //Validate email 
        private bool validateEmail(string email)
        {

            string pattern=@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            if(Regex.IsMatch(email,pattern,RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        //Validate mobile
        private bool validateMobile(string mobile)
        {
            string pattern=@"(\d{3}[-]){2}\d{4}";
            if(Regex.IsMatch(mobile,pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //When the form is active, get the owner of the form
        private void SubscribeForm_Activated(object sender, EventArgs e)
        {
            manager = (ManagerForm)ActiveForm.Owner;
        }
    }
}
