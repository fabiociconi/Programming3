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
/// DATE: 29/05/2017
/// </summary>
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;



namespace Assigment_2
{
    public partial class Calculator : Form
    {
        //product lists
        List<ProductItems> beverages    = new List<ProductItems>();
        List<ProductItems> appetizer    = new List<ProductItems>();
        List<ProductItems> mainCourse   = new List<ProductItems>();
        List<ProductItems> dessert      = new List<ProductItems>();

        //result list
        List<ProductItems> listResult   = new List<ProductItems>();

        public Calculator()
        {
            InitializeComponent();
            Init();//load lists
        }
        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            //go to Google.com
            System.Diagnostics.Process.Start("http://google.com");
        }
        private void Init()
        {
            //Beverage List
            beverages.Add(new ProductItems("Choose one"     , ""        ,    0, 0));
            beverages.Add(new ProductItems("Soda"           , "Beverage", 1.95, 1));
            beverages.Add(new ProductItems("Tea"            , "Beverage", 1.50, 1));
            beverages.Add(new ProductItems("Coffee"         , "Beverage", 1.25, 1));
            beverages.Add(new ProductItems("Mineral Water"  , "Beverage", 2.95, 1));
            beverages.Add(new ProductItems("Juice"          , "Beverage", 2.50, 1));
            beverages.Add(new ProductItems("Milk"           , "Beverage", 1.50, 1));

            comboBoxBeverages.DataSource    = beverages;
            comboBoxBeverages.DisplayMember = "Name";
            //comboBoxBeverages.SelectedIndex = -1;
            //comboBoxBeverages.ValueMember = Convert.ToString("Price");

            //Appetizer List
            appetizer.Add(new ProductItems("Choose one"     , ""         ,    0, 0));
            appetizer.Add(new ProductItems("Buffalo Wings"  , "Appetizer", 5.95, 1));
            appetizer.Add(new ProductItems("Buffalo Fingers", "Appetizer", 6.95, 1));
            appetizer.Add(new ProductItems("Potato Skins"   , "Appetizer", 8.95, 1));
            appetizer.Add(new ProductItems("Nachos"         , "Appetizer", 8.95, 1));
            appetizer.Add(new ProductItems("Mushroom Caps"  , "Appetizer",10.95, 1));
            appetizer.Add(new ProductItems("Shrimp Cocktail", "Appetizer",12.95, 1));
            appetizer.Add(new ProductItems("Chips and Salsa", "Appetizer", 6.95, 1));

            comboBoxAppetizer.DataSource     = appetizer;
            comboBoxAppetizer.DisplayMember  = "Name";
            //comboBoxAppetizer.ValueMember = Convert.ToString("Price");

            //Main Course List
            mainCourse.Add(new ProductItems("Choose one"       , ""           ,     0, 0));
            mainCourse.Add(new ProductItems("Seafood Alfredo"  , "Main Course", 15.95, 1));
            mainCourse.Add(new ProductItems("Chicken Alfredo"  , "Main Course", 13.95, 1));
            mainCourse.Add(new ProductItems("Chicken Picatta"  , "Main Course", 13.95, 1));
            mainCourse.Add(new ProductItems("Turkey Club"      , "Main Course", 11.95, 1));
            mainCourse.Add(new ProductItems("Lobster Pie"      , "Main Course", 19.95, 1));
            mainCourse.Add(new ProductItems("Prime Rib"        , "Main Course", 20.95, 1));

            comboBoxMainCourse.DataSource       = mainCourse;
            comboBoxMainCourse.DisplayMember    = "Name";
            //comboBoxMainCourse.ValueMember = Convert.ToString("Price");

            //Dessert List
            dessert.Add(new ProductItems("Choose one",  ""       ,    0, 0));
            dessert.Add(new ProductItems("Apple Pie",   "Dessert", 5.95, 1));
            dessert.Add(new ProductItems("Sundae",      "Dessert", 3.95, 1));
            dessert.Add(new ProductItems("Carrot Cake", "Dessert", 5.95, 1));
            dessert.Add(new ProductItems("Mud Pie",     "Dessert", 4.95, 1));
            dessert.Add(new ProductItems("Apple Crisp", "Dessert", 5.95, 1));
            
            comboBoxDessert.DataSource      = dessert;
            comboBoxDessert.DisplayMember   = "Name";
            // comboBoxDessert.ValueMember = Convert.ToString("Price");
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            //if (comboBoxBeverages.SelectedIndex != -1)            
            // listResult.Add(beverages[comboBoxBeverages.SelectedIndex]);
            gridPublishList();//update grid
            totalSum();//caluate sum
            
            //clear item selected in the comboxes
            comboBoxBeverages.SelectedIndex     = 0;
            comboBoxAppetizer.SelectedIndex     = 0;
            comboBoxMainCourse.SelectedIndex    = 0;
            comboBoxDessert.SelectedIndex       = 0;

        }
        private void gridPublishList()
        {
            dataGridViewResult.DataSource = null;
            dataGridViewResult.Update();
            dataGridViewResult.Refresh();
            
            //move list to the DataGridView
            dataGridViewResult.DataSource = listResult;

            //Change the Column Names
            dataGridViewResult.Columns[0].HeaderText = "CATEGORY";
            dataGridViewResult.Columns[1].HeaderText = "PRODUCT NAME";
            dataGridViewResult.Columns[2].HeaderText = "PRICE";
            dataGridViewResult.Columns[3].HeaderText = "QTD";
            
            //Change the column's order
            //dataGridViewResult.Columns[0].Visible = false;
            dataGridViewResult.Columns[1].DisplayIndex = 0;
            dataGridViewResult.Columns[2].DisplayIndex = 1;
            dataGridViewResult.Columns[3].DisplayIndex = 2;
        }
        private void dataGridViewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void Calculator_Load(object sender, EventArgs e)
        {

        }
        private void comboBoxBeverages_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check if the customer selected an item
            if (comboBoxBeverages.SelectedIndex > 0)
            {
                //confirm it is the first item
                bool answer = SeachInTheResultList((ProductItems)(comboBoxBeverages.SelectedItem));

                if (!answer)
                {
                    listResult.Add(beverages[comboBoxBeverages.SelectedIndex]);
                }
            
            }
        }
        private void comboBoxMainCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMainCourse.SelectedIndex > 0)
            {
                bool answer = SeachInTheResultList((ProductItems)(comboBoxMainCourse.SelectedItem));
                if (!answer)
                {
                    listResult.Add(mainCourse[comboBoxMainCourse.SelectedIndex]);
                }
            }
        }
        private void comboBoxAppetizer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAppetizer.SelectedIndex > 0)
            {
                bool answer = SeachInTheResultList((ProductItems)(comboBoxAppetizer.SelectedItem));
                if (!answer)
                {
                    listResult.Add(appetizer[comboBoxAppetizer.SelectedIndex]);
                }
            }
        }
        private void comboBoxDessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDessert.SelectedIndex > 0)
            {
                bool answer = SeachInTheResultList((ProductItems)(comboBoxDessert.SelectedItem));
                if (!answer)
                {
                    listResult.Add(dessert[comboBoxDessert.SelectedIndex]);                  

                }
            }
        }
        /// <summary>
        /// If it is the first item sum one in quantity
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private bool SeachInTheResultList(ProductItems item)
        {
            if (listResult.Contains(item))
            {
                foreach (var i in listResult)
                {  
                    if (i.Name == item.Name)
                    {
                        i.Quantity++;          
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Bill's information
        /// </summary>
        private void totalSum()
        {
            //double total = 0.00;
            double tax      = 0;//subtotal+tax

            double subTotal = 0.00;//account subtotal

            double hst      = 0.00;//provincial tax

            foreach (ProductItems item in listResult)
            {
                
                subTotal += item.Price* item.Quantity;
            }
            //subTotal = Math.Round(subTotal,2);

            hst = Convert.ToDouble(textBoxTax.Text);

            if (hst > 0.00)
            {
                tax = (subTotal * hst)/ 100;
            }
            else
            {
                MessageBox.Show("Please Type the tax (hst)");
            }

            //put int the text boxes
            textBoxSubTotal.Text    = "$" + Math.Round(subTotal, 2).ToString(); 
            textBoxTotal.Text       = "$" + (Math.Round(subTotal, 2) 
                                          + Math.Round(tax, 2)).ToString();
            gridPublishList();
        }
        /// <summary>
        /// clear calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            listResult.Clear();//clear list
            textBoxSubTotal.Text    = "$0.00";
            textBoxTotal.Text       = "$0.00";
            textBoxTax.Text         = "0";
            gridPublishList();//update datagridview
        }
        /// <summary>
        /// exit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            //close application
            Application.Exit();
        }
        /// <summary>
        /// remove selected item        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                //DataGridViewRow row;
                //DataGridViewCell cel;
                int selectIndex;
                selectIndex = dataGridViewResult.SelectedCells[0].RowIndex;

                //listResult.FindAll(ProductItems)
                if (listResult[selectIndex].Quantity > 1)
                {
                    listResult[selectIndex].Quantity--;
                }
                else
                {

                    listResult.RemoveAt(selectIndex);
                }

                
                //string tst = listResult.GetRange(selectIndex,0).ToString();
                Debug.WriteLine("Register removed " + selectIndex.ToString());
                //update bill's value
                totalSum();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
