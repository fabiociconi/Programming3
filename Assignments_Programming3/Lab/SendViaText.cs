using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace driver
{
    class SendViaText
    {
        private String cellPhone;

        public SendViaText() { }

        public SendViaText(String phone)
        {
            cellPhone = phone;
        }

        public void setMobile(String phone)
        {
            cellPhone = phone;
        }

        public String getMobile()
        {
            return cellPhone;
        }

        private void sendMessage(string msg)
        {
            Console.WriteLine("The message " + "\"" + msg + "\" has already texted to " + cellPhone);
            string msgBox = "The message " + "\"" + msg + "\" has already texted to " + cellPhone;

            //DisplayTheSubscribers dts = new DisplayTheSubscribers("", msgBox);
            //dts.Show();
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendMessage;
        }

       
    }
}
