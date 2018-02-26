using System;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public delegate int DelegateCalculator(int x, int y);

        public int intoperation;
        public int operatorX;

        //DelegateCalculator delegateObj = null;



        public Form1()
        {
            InitializeComponent();
        }

        private void btnEqual_Click(object sender, System.EventArgs e)
        {


            int operatorY = Convert.ToInt32(txtBoxResult.Text);

            if (intoperation == 1)
            {
                //delegateObj = Add;
                DelegateCalculator delegateObj = Add;
                
                int result = delegateObj(operatorX, operatorY);
                txtBoxResult.Text = result.ToString();
            }
            else if(intoperation == 2)
            {
                DelegateCalculator obj = Sub;
                
                int result = obj(operatorX, operatorY);
                txtBoxResult.Text = result.ToString();

            }
            else if (intoperation == 3)
            {
                DelegateCalculator obj = Multi;
                
 
                int result = obj(operatorX, operatorY);
                txtBoxResult.Text = result.ToString();

            }
            else if (intoperation == 4)
            {
                DelegateCalculator obj = Div;
                
                int result =  obj(operatorX, operatorY);
                txtBoxResult.Text = result.ToString();
            }
 
        }

        private void btnMinus_Click(object sender, System.EventArgs e)
        {
            intoperation = 2;
            operatorX = Convert.ToInt32(txtBoxResult.Text);
            txtBoxResult.Clear();

            //or
            //operatorX = int.Parse(txtBoxResult.Text);
        }

        private void btnTimes_Click(object sender, System.EventArgs e)
        {
            intoperation = 3;
            operatorX = Convert.ToInt32(txtBoxResult.Text);
            txtBoxResult.Clear();
        }

        private void btnDivid_Click(object sender, System.EventArgs e)
        {
            intoperation = 4;
            operatorX = Convert.ToInt32(txtBoxResult.Text);
            txtBoxResult.Clear();
        }
    
        private int Add(int x, int y)
        {
            return x + y;

        }
        private int Sub(int x, int y)
        {
            return x - y;
        }
        private int Multi(int x, int y)
        {
            return x * y;
        }
        private int Div(int x, int y)
        {
            return x / y;
        }

   

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            intoperation = 1;
            operatorX = Convert.ToInt32(txtBoxResult.Text);
            txtBoxResult.Clear();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxResult.Clear();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;

                switch (btn.Name)
                {
                    case "button1":
                        txtBoxResult.Text += "1";
                        break;
                    case "button2":
                        txtBoxResult.Text += "2";
                        break;
                    case "button3":
                        txtBoxResult.Text += "3";
                        break;
                    case "button4":
                        txtBoxResult.Text += "4";
                        break;
                    case "button5":
                        txtBoxResult.Text += "5";
                        break;
                    case "button6":
                        txtBoxResult.Text += "6";
                        break;
                    case "button7":
                        txtBoxResult.Text += "7";
                        break;
                    case "button8":
                        txtBoxResult.Text += "8";
                        break;
                    case "button9":
                        txtBoxResult.Text += "9";
                        break;
                    case "button0":
                        txtBoxResult.Text += "0";
                        break;
                    case "dotButton":
                        if (!txtBoxResult.Text.Contains("."))
                            txtBoxResult.Text += ".";
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry for the inconvenience, Unexpected error occured. Details: " +
                    ex.Message);
            }

        }
    }
}
