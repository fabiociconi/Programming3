using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentRegistration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string Name_Typed;
        private string Address_Typed;
        private string City_Typed;
        private string Province_Typed;
        private string PostalCode_Typed;
        private int Phone_Typed;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var text = combo1.GetValue();
        }

        private void radio1_Checked(object sender, RoutedEventArgs e)
        {
            combo1.Visibility = Visibility.Visible;
            combo2.Visibility = Visibility.Hidden;

        }

        private void radio2_Checked(object sender, RoutedEventArgs e)
        {
            combo2.Visibility = Visibility.Visible;
            combo1.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Name_Typed = txtName.Text;
            Address_Typed = txtAddress.Text;
            City_Typed = txtCity.Text;
            Province_Typed= txtProvince.Text;
            PostalCode_Typed = txtPostal.Text;
            Phone_Typed = int.Parse(txtPhone.Text);

            var combo1txt = combo1.SelectedItem;
            var combo2txt = combo2.SelectedItem;

            string text = "info" + Name_Typed+
                " "+ Address_Typed+
                " "+ City_Typed+
                " " + Province_Typed+
                " " + PostalCode_Typed+
                " " + Phone_Typed;
            txtDisplay.Text = text;

        }
    }
}
