//*         
//  Fabio Alexandre Ciconi
//  Student Number 300930989
//  Centennial College
//  15/05/2017
//*
using System;
using System.Windows.Forms;

namespace Assigment_01
{
    static class Program
    {
        [STAThread]
        // main Method 
        // Load First Form - Notification Manager Form
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NotificationManagerForm());
        }
    }
}
