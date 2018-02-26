//*         
//  Fabio Alexandre Ciconi
//  Student Number 300930989
//  Centennial College
//  15/05/2017
//*
using System.Windows.Forms;

namespace Assigment_01
{
    class SendViaEmail
    {

        private string email;
                
        Publisher pb = new Publisher();
        
        //default constructor
        public SendViaEmail()
        {  }

        //constructor that recieve email
        public SendViaEmail(string email)
        {
            Email = email;
        }

        // get and set Method to Email that comming from constructor
        public string Email { get => email; set => email = value; }

        //Add email of the subscribe list
        public void AddEmailList()
        {
            SubscribeForm.listEmail.Add(this.email);
        }
        //Remove email of the subscribe list
        public void RemoveEmailList()
        {
            SubscribeForm.listEmail.Remove(this.email);
        }

        //Sent personnalized message to the email
        public void SendEmail(string msg)
        {           
            MessageBox.Show("The message" + "\"" + msg + "\" has sent to " + this.email); 
        }
        //use of delegate
        public void Subscribe(Publisher pub)
        {
            pub.publishmsg = SendEmail;
        }

    }
}
