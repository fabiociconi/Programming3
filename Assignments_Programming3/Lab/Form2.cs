using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace driver
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //ArrayList list = new ArrayList();
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            f1.Closed += (s, args) => this.Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendViaEmail eMail = new SendViaEmail( textBox1.Text);
            SendViaText phone =new SendViaText( textBox2.Text);

            if (checkBox1.Checked)
            {
                //Regex emailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?
                //                ^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+
                //                [a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
                //if (emailRegex.IsMatch(textBox1.Text))
                //{
                //        Program.eMail.Add(eMail);
                //}
                //else
                //{
                //    MessageBox.Show(" eMail not valid");
                //}
                Program.eMail.Add(eMail);
            }
            //textBox2.Text = Program.eMail.ToString();

            if (checkBox2.Checked)
            {
                //Regex phoneNumpattern = new Regex(@"\[0-9]{3}\s+[0-9]{3}\s+[0-9]{4}");
                //if (phoneNumpattern.IsMatch(textBox1.Text))
                //{
                //   Program.phoneNumber.Add(phone);
                //}
                //else
                //{
                //    MessageBox.Show("Invalid phone number");
                //}

                Program.phoneNumber.Add(phone);
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //Program.eMail.Remove()
            }
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
