//*         
//  Fabio Alexandre Ciconi
//  Student Number 300930989
//  Centennial College
//  15/05/2017
//*

using System.Windows.Forms;

namespace Assigment_01
{
    class SendViaMobile
    {
        private string mobile;

        Publisher pb = new Publisher();
        
        //default constructor
        public SendViaMobile()
        { }
        //constructor that recieve mobile phone
        public SendViaMobile(string mobile)
        {
            Mobile = mobile;
        }

        // get and set Method to Email that comming from constructor
        public string Mobile { get => mobile; set => mobile = value; }

        //Add phone of the subscribe list
        public void AddMobileList()
        {
            SubscribeForm.listPhone.Add(this.mobile);
        }
        //Remove phone of the subscribe list
        public void RemoveMobileList()
        {
            SubscribeForm.listPhone.Remove(this.mobile);
        }
        //Sent personnalized message to the mobile phone
        public void SendPhone(string msg)
        {            
            MessageBox.Show("The message" + "\"" + msg + "\" has to " + this.mobile);
        }
        //use of delegate
        public void Subscribe(Publisher pub)
        {
            pub.publishmsg = SendPhone;
        }


    }
}
