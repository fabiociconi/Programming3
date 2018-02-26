using System;
using System.Windows.Forms;

namespace Assigment_2
{
    static class Program
    {
        /// <summary>
        /// 
        /// PROGRAMMING - 3
        /// 
        /// Assignment#2 – Advanced GUI
        /// 
        /// Due Date:	Midnight of June 1 (Friday)
        /// ---------------------------------------
        /// Author: Fabio Alexadre Ciconi
        /// Number: 300930989
        /// DATE: 23/05/2017
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculator());
        }
    }
}
