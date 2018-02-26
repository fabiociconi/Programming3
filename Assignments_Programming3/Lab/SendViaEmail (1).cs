using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace driver
{
    class SendViaEmail
    {
        private string emailAddr;
        public SendViaEmail() { }

        public SendViaEmail(string emailAddr)
        {
            this.emailAddr = emailAddr;

        }
        public void setEmailAddr(string emailAddr)
        {
            this.emailAddr = emailAddr;
        }
        public string getEmailAddr()
        {
            return emailAddr;
        }
        public void sendEmail(string msg)
        {
            string emailPrint ="the msg" + "\"" + msg + "\"has already send to " + emailAddr;

            Console.WriteLine(emailPrint);

           //System.Windows.Forms(Console.Write(emailPrint));
            
        }
        public void subscribe(Publisher pub)
        {
            pub.publishmsg += sendEmail;
        }
        public void unSubscribe(Publisher pub)
        {
            pub.publishmsg -= sendEmail;
        }
      
    }
}
