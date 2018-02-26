using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fabio_Ciconi_Test03_Sec003_Ex01
{
    public partial class Form1 : Form
    {
        static SortedDictionary<int, Employee> SortedDictEmployeeInfo;
        static List<int> rdnIntegers = new List<int>();
        

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            SortedDictEmployeeInfo = new SortedDictionary<int, Employee>();




            employee = new Employee("Fabio1", 1400);
            SortedDictEmployeeInfo.Add(1, employee);
            employee = new Employee("Fabio2", 1400);
            SortedDictEmployeeInfo.Add(2, employee);
            employee = new Employee("Fabio3", 1500);
            SortedDictEmployeeInfo.Add(3, employee);
            employee = new Employee("Fabio4", 12600);
            SortedDictEmployeeInfo.Add(4, employee);
            employee = new Employee("Fabio5", 1400);
            SortedDictEmployeeInfo.Add(5, employee);



            textBoxOutput.Clear();


            textBoxOutput.Text = string.Join(" ", SortedDictEmployeeInfo);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(textBoxID.Text);
                string name = textBoxName.Text;
                double salary = double.Parse(textBoxSal.Text);
                string depto = textBoxDepto.Text;

                Employee employee = new Employee(name, salary);

                ADDSortedDictEmployeeInfo(SortedDictEmployeeInfo, employee);
            }
            catch (Exception)
            {

                MessageBox.Show("Error", "Warning");
            }

        }

        private void ADDSortedDictEmployeeInfo(SortedDictionary<int, Employee> sortedDictEmployeeInfo, Employee emp)
        {
            try
            {

                sortedDictEmployeeInfo.Add(sortedDictEmployeeInfo.Keys.Max() + 1, emp);

                MessageBox.Show("An element was included");
                textBoxID.Clear();
                textBoxName.Clear();
                textBoxSal.Clear();
                textBoxDepto.Clear();

            }
            catch (ArgumentException)
            {
                MessageBox.Show("An element with Key already exists.");

            }

        }

        private void buttonDelte_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxID.Text);
                RemoveDictionaryItem(SortedDictEmployeeInfo, id);
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }

        }

        private void RemoveDictionaryItem(SortedDictionary<int, Employee> sortedDictEmployeeInfo, int id)
        {
            try
            {
                sortedDictEmployeeInfo.Remove(id);
                MessageBox.Show("Deleted" + id);
            }
            catch (Exception)
            {
                MessageBox.Show("Not Exist");

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxID.Text);
                SearchDictionaryItem(SortedDictEmployeeInfo, id);

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private void SearchDictionaryItem(SortedDictionary<int, Employee> sortedDictEmployeeInfo, int id)
        {
            try
            {
                if (sortedDictEmployeeInfo.ContainsKey(id))
                {
                    textBoxOutput.Clear();

                    textBoxOutput.Text = string.Join(" ", id + "" + sortedDictEmployeeInfo.ToString());

                }

            }
            catch (Exception)
            {

                Console.WriteLine("Not Exist.");
            }
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            DisplayDictionary(SortedDictEmployeeInfo);
        }

        private void DisplayDictionary(SortedDictionary<int, Employee> SortedDictEmployeeInfo)
        {
            textBoxOutput.Clear();
            foreach (var key in SortedDictEmployeeInfo.Keys)
            {
                textBoxOutput.Text = string.Join(key + "-", SortedDictEmployeeInfo[key] + "\n");

            }
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            MaxDictionaryItem(SortedDictEmployeeInfo);
        }

        private void MaxDictionaryItem(SortedDictionary<int, Employee> sortedDictEmployeeInfo)
        {
            double max = 0;
            string name = null;

            foreach (var item in sortedDictEmployeeInfo)
            {

                if (item.Value.Salary > max)
                {
                    max = item.Value.Salary;
                    name = item.Value.Name;
                }


            }
            textBoxOutput.Clear();
            textBoxOutput.Text = "Name" + name + "-" + "Salary:" + max;
        }

        private void groupBoxRight_Enter(object sender, EventArgs e)
        {

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            listBoxInt.Items.Clear();
            rdnIntegers.Clear();
            Random rdn = new Random();

            for (int i = 0; i <= 9; i++)
            {
                rdnIntegers.Add(rdn.Next(10, 99));
            }

            foreach (var item in rdnIntegers)
            {
                listBoxInt.Items.Add(item).ToString();

            }
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();

            var total = rdnIntegers.Sum(x => (x));
            textBoxOutput.Text = total.ToString();

        }

        private void buttonGT50_Click(object sender, EventArgs e)
        {

            textBoxOutput.Clear();
            int value = 50;
            foreach (var item in rdnIntegers)
            {
                var total = rdnIntegers.Where(x => x > value);
                textBoxOutput.Text = string.Join("-", total);
            }


        }

        private void buttonAvg_Click(object sender, EventArgs e)
        {

            textBoxOutput.Clear();

            var total = rdnIntegers.Average(x => (x));
            textBoxOutput.Text = total.ToString();
        }
    }
}
