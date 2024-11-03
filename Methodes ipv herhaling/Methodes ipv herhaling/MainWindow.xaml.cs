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

namespace Methodes_ipv_herhaling
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

        private void DrawButton_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush color = new SolidColorBrush(Colors.Black);
                          
            DrawRectangle(DrawCanvas, color, 10, 20, 20);
            DrawRectangle(DrawCanvas, color, 10, 20, 40);
            DrawRectangle(DrawCanvas, color, 10, 20, 60);

            JustDoIt("Jp");
        }

        private void JustDoIt(string naam)
        {
            MessageBox.Show(naam);
        }

        private void DrawRectangle(Canvas drawCanvas, SolidColorBrush color,
                                    double xPosition, double yPosition, double size)
        {   
            Rectangle rect = new Rectangle();
            rect.Width = size;
            rect.Height = size;
            rect.Margin = new Thickness(xPosition, yPosition, 0, 0);
            rect.Stroke = color;
            drawCanvas.Children.Add(rect);
        }
    }
}
