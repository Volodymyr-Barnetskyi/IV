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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Weather.Weather.getData();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(textbox1.Text=="" || textbox2.Text=="" || combobox1.Text == "")
            {
                MessageBox.Show("Ви не заповнили всі поля!");
                return;
            }
            double r = Convert.ToDouble(textbox1.Text) * Convert.ToDouble(textbox2.Text);

            double rezultat=0;
            if (combobox1.Text == "Болгарія" && radiobutton1.IsChecked.Value)
            {
                rezultat = r * 100;
            }
            if (combobox1.Text == "Болгарія" && radiobutton2.IsChecked.Value)
            {
                rezultat = r * 150;
            }
            if (combobox1.Text == "Німеччина" && radiobutton1.IsChecked.Value)
            {
                rezultat = r * 160;
            }
            if (combobox1.Text == "Німеччина" && radiobutton2.IsChecked.Value)
            {
                rezultat = r * 200;
            }
            if (combobox1.Text == "Польща" && radiobutton1.IsChecked.Value)
            {
                rezultat = r * 120;
            }
            if (combobox1.Text == "Польща" && radiobutton2.IsChecked.Value)
            {
                rezultat = r * 180;
            }
            if (checkbox1.IsChecked == true) { rezultat += Convert.ToDouble(textbox2.Text) * 50; }
            labelresult.Content =$"Вартість: ${rezultat} ";
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
