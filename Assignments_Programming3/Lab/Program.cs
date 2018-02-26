using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace driver
{
     class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        Publisher publish = new Publisher();

        //SendViaEmail sendMail = new SendViaEmail(Form2.eMail);
        //SendViaText sendText = new SendViaText(Form2.phone);

        public static List<SendViaEmail> eMail = new List<SendViaEmail>();
        public static List<SendViaText> phoneNumber = new List<SendViaText>();


    }
    }

