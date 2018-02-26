//*         
//  Fabio Alexandre Ciconi
//  Student Number 300930989
//  Centennial College
//  15/05/2017
//*
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Assigment_01
{
    public partial class SubscribeForm : Form
    {
        //variable to check if the information are correct
        public bool EmailOk = false;
        public bool PhoneOK = false;

        //variables to check if the values exists already in the lists
        public bool ContainsListEmail = false;
        public bool ContainsListPhone = false;
        
        //main subscribes lists
        public static List<string> listEmail = new List<string>();
        public static List<string> listPhone = new List<string>();

        //iniitalize Form
        public SubscribeForm()
        {
            InitializeComponent();
        }

        //Subscribe and Check if informations are valid and it already exists in the list
        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            //constist email format
            TestConsist();

            //valid if the e-mail and phone are checked
            if (checkBoxEmail.Checked == true && checkBoxMobile.Checked == true)
            {
                if ((EmailOk) && (PhoneOK))
                {
                    SendViaEmail sendEmail   = new SendViaEmail(textBoxEmail.Text);
                    SendViaMobile sendMobile = new SendViaMobile(textBoxPhone.Text);

                    //verify if they are in the lists
                    ContainsListEmail = ContainsEmail(textBoxEmail.Text);
                    ContainsListPhone = ContainsPhone(textBoxPhone.Text);

                    //if no contains in the list, so include them and clear textboxes to accept new values
                    if (!ContainsListEmail && !ContainsListPhone)
                    {
                        sendEmail.AddEmailList();
                        sendMobile.AddMobileList();
                        MessageBox.Show("Subscribed."+ "\n" +
                            "Email add: " + textBoxEmail.Text + "\n"+ "Phone add: " + textBoxPhone.Text);
                        textBoxEmail.Clear();
                        textBoxPhone.Clear();
                    }
                    //if contains show warning message
                    else if ((ContainsListEmail) || (ContainsListPhone))
                    {
                        MessageBox.Show("It is already in the list.....");
                    }
                }
            }
            // if choose only email/ check it is valid and if contain in the list
            else if (checkBoxEmail.Checked == true && checkBoxMobile.Checked == false)
            {
                if (EmailOk)
                {
                    SendViaEmail sendEmail = new SendViaEmail(textBoxEmail.Text);
                    ContainsListEmail = ContainsEmail(textBoxEmail.Text);

                    if (!ContainsListEmail)
                    {
                        sendEmail.AddEmailList();
                        MessageBox.Show("Subscribed." + "\n" + "Email add : " + textBoxEmail.Text);
                        textBoxEmail.Clear();
                    }
                    else
                    {
                        MessageBox.Show("It is already in the list.....");
                    }
                }
                //else
                //{
                //    MessageBox.Show("Invalid email address");
                //}
            }
            // if choose only phone/ check it is valid and if contain in the list
            else if (checkBoxEmail.Checked == false && checkBoxMobile.Checked == true)
            {
                if (PhoneOK)
                {
                    SendViaMobile sendMobile = new SendViaMobile(textBoxPhone.Text);
                    ContainsListPhone = ContainsPhone(textBoxPhone.Text);
                    if (!ContainsListPhone)
                    {
                        sendMobile.AddMobileList();
                        MessageBox.Show("Subscribed." + "\n" + "Phone add : " + textBoxPhone.Text);
                        textBoxPhone.Clear();
                    }
                    else
                    {
                        MessageBox.Show("It is already in the list.....");
                    }

                }
                //else
                //{
                //    MessageBox.Show("Invalid phone number");
                //}
            }
            //if do not choose anything shows a warning
            else
            {
                MessageBox.Show("Choose one.....");
            }
        }
        //method to return if the value is already in the list
        private bool ContainsPhone(string text)
        {
            if (listPhone.Contains(text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //method to return if the value is already in the list
        private bool ContainsEmail(string text)
        {
            if (listEmail.Contains(text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //method to return if the value is valid
        private void TestConsist()
        {
            if (checkBoxEmail.Checked)
            {
                EmailOk = CheckEmail(textBoxEmail.Text);
                if (!EmailOk)
                {
                    MessageBox.Show("NO VALID EMAIL");
                }
            }
            if (checkBoxMobile.Checked)
            {
                PhoneOK = CheckPhone(textBoxPhone.Text);
                if (!PhoneOK)
                {
                    MessageBox.Show("NO VALID PHONE NUMBER");
                }
            }
        }
        //Method that verify pattern
        private static bool CheckEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }
        //Method that verify pattern
        private static bool CheckPhone(string phone)
        {
            /*
                ^	    Assert position at the beginning of the string.
                \(	    Match a literal “(“
                 ?	    between zero and one time.
                (	    Capture the enclosed match to back reference 1
               [0-9]	Match a digit
                {3}	    exactly three times.
                )	    End capturing group 1.
                \)	    Match a literal “)”
                ?	    between zero and one time.
                [-. ]	Match one character from the set “-. “
                ?	    between zero and one time.
                ?	    [Match the remaining digits and separator.]
                $	    Assert position at the end of the string.
            */
            Regex regex = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");

            if (regex.IsMatch(phone))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //Close the form and back to the main form
        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        //verify if the checkbox was changed 
        private void checkBoxEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEmail.Checked)
            {
                textBoxEmail.Enabled = true;
                textBoxEmail.Clear();

            }
            else
            {
                textBoxEmail.Enabled = false;
                textBoxEmail.Text="Email Address";
            }
        }

        //verify if the checkbox was changed 
        private void checkBoxMobile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMobile.Checked)
            {
                textBoxPhone.Enabled = true;
                textBoxPhone.Clear();
            }
            else
            {
                textBoxPhone.Enabled = false;
                textBoxPhone.Text= "Phone number";
            }
        }
        //Unsubscribe and Check if informations are valid and it is not exists in the list
        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            TestConsist();
            if (checkBoxEmail.Checked == true && checkBoxMobile.Checked == true)
            {
                if ((EmailOk) && (PhoneOK))
                {
                    SendViaEmail sendEmail = new SendViaEmail(textBoxEmail.Text);
                    SendViaMobile sendMobile = new SendViaMobile(textBoxPhone.Text);

                    ContainsListEmail = ContainsEmail(textBoxEmail.Text);
                    ContainsListPhone = ContainsPhone(textBoxPhone.Text);

             
                    if (ContainsListEmail && ContainsListPhone)
                    {

                        sendEmail.RemoveEmailList();
                       
                        MessageBox.Show("Unsubscribed" + "\n"
                                        + "Email Removed: " + textBoxEmail.Text + "\n" + "Phone Remove: " + textBoxPhone.Text);

                        textBoxEmail.Clear();
                        textBoxPhone.Clear();
                    }
                    else if ((!ContainsListEmail) || (!ContainsListPhone))
                    {
                        MessageBox.Show("There are not in the list.....");
                    }
                }
            }
            else if (checkBoxEmail.Checked == true && checkBoxMobile.Checked == false)
            {
                if (EmailOk)
                {
                    SendViaEmail sendEmail = new SendViaEmail(textBoxEmail.Text);
                    ContainsListEmail = ContainsEmail(textBoxEmail.Text);

                    if (ContainsListEmail)
                    {
                        sendEmail.RemoveEmailList();
                        textBoxEmail.Clear();
                    }
                    else
                    {
                        MessageBox.Show("It is not in the list.....");
                    }
                }
                //else
                //{
                //    MessageBox.Show("Invalid email address");
                //}
            }
            else if (checkBoxEmail.Checked == false && checkBoxMobile.Checked == true)
            {
                if (PhoneOK)
                {
                    SendViaMobile sendMobile = new SendViaMobile(textBoxPhone.Text);
                    ContainsListPhone = ContainsPhone(textBoxPhone.Text);

                    if (ContainsListPhone)
                    {
                        sendMobile.RemoveMobileList();
                        textBoxPhone.Clear();
                    }
                    else
                    {
                        MessageBox.Show("It is not in the list.....");
                    }
                }
                //else
                //{
                //    MessageBox.Show("Invalid phone number");
                //}
            }
            else
            {
                MessageBox.Show("You need to choose somenting.....");
            }
        }

        private void SubscribeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
