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

namespace var_ber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bereken_Click(object sender, RoutedEventArgs e)
        {
            int number = 44;
            string text = Convert.ToString(number);
            MessageBox.Show(text);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            int cents;
            cents = Convert.ToInt32(inputCents.Text);
            Euros.Text = Convert.ToString(cents / 100);
            centsTextBlock.Text = Convert.ToString(cents % 100);

            int euro = cents / 100;
            cents = cents % 100;
            fullCentense.Text = $"{euro,15} euros en {cents,-15} cents";
        }
    }
}
