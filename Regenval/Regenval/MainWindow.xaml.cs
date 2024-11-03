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

namespace Regenval
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

        private void TekenKnop_Click(object sender, RoutedEventArgs e)
        {
            int heigthRec = 20;

            FillRectangle(10, 10, 150, heigthRec);
            FillRectangle(10, 10 +2 * heigthRec, 175, heigthRec);
            FillRectangle(10, 10 +4 * heigthRec, 120, heigthRec);
            FillRectangle(10, 10 +6 * heigthRec, 130, heigthRec);
        }

        private void FillRectangle(double x, double y, double width, double height) 
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Stroke = new SolidColorBrush(Colors.Black);
            rectangle.Fill = new SolidColorBrush(Colors.Blue);
            rectangle.Width = width;
            rectangle.Height = height;
            rectangle.Margin = new Thickness(x, y, 0, 0);
            tekenCanvas.Children.Add(rectangle);
        }
    }
}
