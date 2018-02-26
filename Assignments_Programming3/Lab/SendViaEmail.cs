/*
 * Author       : Raveena Tayal
 * Student ID   : 300813330
 * Last Modified: 1/23/2016
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_Assignment01
{
    class SendViaEmail
    {
        private String email;
        ManagerForm managerForm=new ManagerForm();

        //Constructors
        public SendViaEmail() { }

        public SendViaEmail(String email)
        {
            this.email = email;
        }

        //Setter
        public void setEmailAddr(String email)
        {
            this.email = email;
        }

        //Getter
        public String getEmailAddr()
        {
            return email;
        }

        //Add email to list if its new
        public void addToEmailList()
        {
            if (!managerForm.emailList.Contains(this.email))
            managerForm.emailList.Add(this.email);
        }

        //Remove email from list if it exists
        public void removeFromEmailList()
        {
            managerForm.emailList.Remove(this.email);
        }

        //Subscribe an email
        public void Subscribe(ManagerForm manager)
        {
            manager.publishmsg += addToEmailList;
            managerForm = manager;
        }

        //unsubscribe an email
        public void Unsubscribe(ManagerForm manager)
        {
            manager.publishmsg += removeFromEmailList;
            managerForm = manager;
        }
    }
}
