using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Generic_Linear_Search_Method
{
    public partial class Form1 : Form
    {

        //generic lists
        private static List<int> rdnIntegers = new List<int>();
        private static List<double> rdnDoubles = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// show 10 random integers numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRandomIntegers_Click(object sender, EventArgs e)
        {
            TextBoxIntegers.Clear();
            rdnIntegers.Clear();
            Random rdn = new Random();

            for (int i = 0; i <= 9; i++)
            {
                rdnIntegers.Add(rdn.Next(0, 9));
            }

            foreach (var item in rdnIntegers)
            {
                TextBoxIntegers.Text = string.Join("  ", rdnIntegers);

            }
            //TextBoxIntegers.Text = String.Join(",", rdnIntegers);
            //Debug.Write("rdnIntegers" + rdnIntegers);
            //Debug.Write("rdnIntegers" + TextBoxIntegers.Text);
        }
        /// <summary>
        /// show 10 random double numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRandomDoubles_Click(object sender, EventArgs e)
        {
            TextBoxDouble.Clear();
            rdnDoubles.Clear();

            Random rdn = new Random();
            for (int i = 0; i <= 9; i++)
            {
                rdnDoubles.Add(Math.Round((rdn.NextDouble() * 10.0), 1));
            }
            foreach (var item in rdnDoubles)
            {
                TextBoxDouble.AppendText("  " + item.ToString());
            }

            // Debug.Write("rdnDoubles" + rdnDoubles);
            // Debug.Write("rdnDoubles" + TextBoxIntegers.Text);
        }
        /// <summary>
        /// search method - show the position if find the number
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private int Search<T>(string name, T x, List<T> y) where T : IComparable<T>
        {
            var numberToSearch = x;
            var listEntered = y;
            var result = -1;

            for (int i = 0; i < listEntered.Count; i++)
            {
                if (listEntered[i].CompareTo(numberToSearch) == 0)
                {
                    result = i;
                    if (name.Equals("Integer-Test"))
                    {
                        labelResultInteger.Visible = true;
                        labelResultInteger.Text = "The number is in the " +
                        result + " positon";
                    }
                    else
                    {
                        labelResultDouble.Visible = true;
                        labelResultDouble.Text = "The number is in the " +
                        result + " positon";
                    }
                    //debug.Write("result:" + result);
                    break;
                }
                else
                {
                    if (name.Equals("Integer-Test"))
                    {
                        labelResultInteger.Visible = true;
                        labelResultInteger.Text = "The number is Not in the Intger Array\n Rc: " + result;
                    }
                    else
                    {
                        labelResultDouble.Visible = true;
                        labelResultDouble.Text = "The number is Not in the Double Array\n Rc: " + result;
                    }
                }
            }
            //Debug.Write("result:" + result);

            return result;
        }
        /// <summary>
        /// search button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            labelWarning.Visible = false;

            try
            {
                if (TextBoxIntegers.Text == "" || TextBoxDouble.Text == "")
                {
                    labelWarning.Visible = true;
                    labelWarning.Text = "Please click on buttons to generate Arrays";
                }
                else if (TextBoxSeachInteger.Text == "" || TextBoxSeachDouble.Text == "")
                {
                    labelWarning.Visible = true;
                    labelWarning.Text = "Please Type an Interger and a Double to Search";
                }
                else
                {
                    int numberInteger = int.Parse(TextBoxSeachInteger.Text);
                    double numberDouble = double.Parse(TextBoxSeachDouble.Text);

                    Search("Integer-Test", numberInteger, rdnIntegers);
                    Search("Double-Test", numberDouble, rdnDoubles);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro Description: " +
                    "Invalid Value, type integer and double numbers ONLY", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        /// <summary>
        /// Clear alll text boxes
        /// invisiable label results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {

            //clear everthing
            TextBoxDouble.Clear();
            TextBoxIntegers.Clear();
            TextBoxSeachDouble.Clear();
            TextBoxSeachInteger.Clear();
            labelResultDouble.Visible = false;
            labelResultInteger.Visible = false;
            labelWarning.Visible = false;

        }
        /// <summary>
        /// Close application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
