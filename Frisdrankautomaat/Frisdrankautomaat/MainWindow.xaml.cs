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

namespace Frisdrankautomaat
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

        private void drankKnop_Click(object sender, RoutedEventArgs e)
        {
            int amountGiven = 90;
            int cost = 45;
            int amount100, amount50, amount20, amount10, amount5, amount2, amount1;
            int change = amountGiven - cost;

            amount100 = change / 100;
            change = change % 100;

            //amount50 = change / 50;
            //change = change % 50;

            amount20 = change / 20;
            change = change % 20;

            amount10 = change / 10;
            change = change % 10;

            amount5 = change / 5;
            change = change % 5;

            amount2 = change / 2;
            change = change % 2;

            amount1 = change / 1;
            change = change % 1;

            MessageBox.Show("Aantal van 1 euro is: " + amount100);
            //MessageBox.Show(String.Format("Number of 1 euro coins is {0:d}", amount100));
            //MessageBox.Show("Aantal van 50 cent is: " + amount50);
            MessageBox.Show("Aantal van 20 cent is: " + amount20);
            MessageBox.Show("Aantal van 10 cent is: " + amount10);
            MessageBox.Show("Aantal van 5 cent is: " + amount5);
            MessageBox.Show("Aantal van 2 cent is: " + amount2);
            MessageBox.Show("Aantal van 1 euro is: " + amount1);
        }
    }
}
