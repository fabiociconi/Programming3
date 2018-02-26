using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment_06
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        //lists
        private static List<int> rdnIntegers = new List<int>();
        private static List<double> rdnDoubles = new List<double>();
        private static List<char> rdnChar = new List<char>();

        //type in the list
        private char listType;

        //CONST
        private const int MAX_NUM = 10;

        //delegate
        public delegate bool Calcute(int number);


        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonCalcAsync_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                long numberTyped = int.Parse(textBoxAsync.Text);

                Task<long> task1 = Task.Run(() => CalcFatorial(numberTyped));
                labelResultFatorial.Content = "Calculate..: ";
                await Task.Delay(2000);
                labelResultFatorial.Content = "Result: \n" + task1.Result.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Insert a Number", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numFat"></param>
        /// <returns></returns>
        private long CalcFatorial(long numFat)
        {

            if (numFat == 0)
            {
                return 1;
            }
            else
            {
                return numFat * CalcFatorial(numFat - 1);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCheckEvenOdd_Click(object sender, RoutedEventArgs e)
        {
            Calcute X1 = IsEven;
            try
            {
                int result = int.Parse(textBoxEvenOdd.Text);
                bool test = X1(result);

                labelResultEvenOdd.Content = "Result EVEN: " + test;
                if (!test)
                {
                    Calcute X2 = IsOdd;
                    bool test2 = X2(result);
                    labelResultEvenOdd.Content = "Result ODD: " + test2;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Insert a Number", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static bool IsEven(int number) => number % 2 == 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static bool IsOdd(int number) => number % 2 == 1;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGenValue_Click(object sender, RoutedEventArgs e)
        {
            rdnIntegers.Clear();
            rdnDoubles.Clear();
            rdnChar.Clear();

            listBoxNumbersChar.Items.Clear();

            if (radioButtonIntegers.IsChecked == true)
            {
                GenerateListIntegers();
                listType = 'I';
            }
            else if (radioButtonDouble.IsChecked == true)
            {
                GenerateListDoubles();
                listType = 'D';
            }
            else if (radioButtonChar.IsChecked == true)
            {
                GenerateListChars();
                listType = 'C';
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void GenerateListChars()
        {

            char[] charArray = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            Random rdn = new Random();

            for (int i = 0; i <= MAX_NUM; i++)
            {

                var items = rdn.Next(0, charArray.Length);
                rdnChar.Add(charArray[items]);

            }
            foreach (var item in rdnChar)
            {
                listBoxNumbersChar.Items.Add(item).ToString();

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool SearchData<T>(T x, List<T> y) where T : IComparable<T>
        {
            var toSearch = x;
            var listEntered = y;
            for (int i = 0; i < listEntered.Count; i++)
            {
                if (listEntered[i].CompareTo(toSearch) == 0)
                {
                    MessageBox.Show("FOUND", "OK", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    return true;
                }
            }

            MessageBox.Show("NOT FOUND", "NOK", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        private void GenerateListDoubles()
        {
            Random rdn = new Random();
            for (int i = 0; i <= MAX_NUM; i++)
            {
                rdnDoubles.Add(Math.Round((rdn.NextDouble() * 10.0), 1));
            }
            foreach (var item in rdnDoubles)
            {
                listBoxNumbersChar.Items.Add(item).ToString();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void GenerateListIntegers()
        {
            Random rdn = new Random();
            for (int i = 0; i <= MAX_NUM; i++)
            {
                rdnIntegers.Add(rdn.Next(0, 99));
            }

            foreach (var item in rdnIntegers)
            {
                listBoxNumbersChar.Items.Add(item).ToString();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {

            if (textBoxSearch.Text == "")
            {

                MessageBox.Show("Type somenthing to search", "NOK", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            if (listType == 'I')
            {


                try
                {
                    int item = int.Parse(textBoxSearch.Text);
                    SearchData(item, rdnIntegers);
                }
                catch (Exception)
                {
                    MessageBox.Show("ONLY INTEGER NUMBERS", "NOK", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            else if (listType == 'D')
            {

                try
                {
                    double item = double.Parse(textBoxSearch.Text);
                    SearchData(item, rdnDoubles);
                }
                catch (Exception)
                {
                    MessageBox.Show("ONLY DOUBLE NUMBERS", "NOK", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            else if (listType == 'C')
            {

                try
                {
                    char item = char.Parse(textBoxSearch.Text);
                    SearchData(item, rdnChar);
                }
                catch (Exception)
                {
                    MessageBox.Show("ONLY CHARACTERS", "NOK", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDisplay_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int lowIndex = int.Parse(textBoxLowIndex.Text);
                int highIndex = int.Parse(textBoxHighIndex.Text);

                switch (listType)
                {
                    case 'I':
                        {
                            PrintData(rdnIntegers, lowIndex, highIndex);
                        }
                        break;

                    case 'D':
                        {
                            PrintData(rdnDoubles, lowIndex, highIndex);
                        }
                        break;
                    case 'C':
                        {
                            PrintData(rdnChar, lowIndex, highIndex);
                        }
                        break;

                    default:
                        {
                            MessageBox.Show("Error Contact Support",
                            "NOK", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        break;
                }
                //if (listType == 'I')
                //{
                //    PrintData(rdnIntegers, lowIndex, highIndex);
                //}
                //else if (listType == 'D')
                //{
                //    PrintData(rdnDoubles, lowIndex, highIndex);
                //}
                //else if (listType == 'C')
                //{
                //    PrintData(rdnChar, lowIndex, highIndex);
                //}
            }
            catch (Exception)
            {
                MessageBox.Show("ONLY NUMBERS", "NOK", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            // textBoxDisplay.Text = resul

        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputList"></param>
        /// <param name="lowIndex"></param>
        /// <param name="highIndex"></param>
        /// <returns></returns>
        private List<T> PrintData<T>(List<T> inputList, int lowIndex, int highIndex)
        {
            var result = new List<T>();
            int qtd = 0;
            textBoxDisplay.Clear();


            try
            {
                if ((highIndex < 0) || (lowIndex < 0))
                {

                    MessageBox.Show("Neither HighIndex nor LowIndex can be Less than 0",
                        "NOK", MessageBoxButton.OK, MessageBoxImage.Exclamation);

                }
                if (highIndex > inputList.Count)
                {
                    MessageBox.Show("highIndex bigger than the content in the list",
                        "NOK", MessageBoxButton.OK, MessageBoxImage.Exclamation);

                }

                if (highIndex >= lowIndex)
                {
                    for (int i = lowIndex; i <= highIndex; i++)
                    {
                        result.Add(inputList[i]);
                        qtd++;
                    }
                }
                else
                {
                    MessageBox.Show("highIndex less than lowIndex", "NOK", MessageBoxButton.OK, MessageBoxImage.Exclamation);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR " + ex, "NOK", MessageBoxButton.OK, MessageBoxImage.Stop);


            }

            foreach (var item in result)
            {
                textBoxDisplay.Text += item.ToString() + "  ";
            }

            return result;
        }
    }
}
