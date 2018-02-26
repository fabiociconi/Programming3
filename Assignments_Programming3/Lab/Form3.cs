using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace driver
{
    public partial class Form3 : Form
    { Publisher publish = new Publisher();
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            f1.Closed += (s, args) => this.Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string messageToPublish = textBox1.Text;

            //textBox2.Text = messageToPublish;
            //textBox2.Text = "the msg" + "\"" + messageToPublish + "\"has already send to ";
            foreach(SendViaEmail E in Program.eMail){
                E.subscribe(publish);
                publish.PublishMessage(messageToPublish);

            }
            foreach(SendViaText T in Program.phoneNumber)
            {
                T.Subscribe(publish);
                publish.PublishMessage(messageToPublish);
            }

            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
