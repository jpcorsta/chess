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

            DrawTriangle(DrawCanvas, color, 100, 10, 40, 40);

            int area = Bereken(10, 30);
        }

        private int Bereken(int x, int y)
        {
            int berekening = x + y; 
            return berekening;
            
        }

        private void DrawTriangle(Canvas drawCanvas, SolidColorBrush color, 
                                    int topX, int topY, int width, int height)
        {
            DrawLine(drawCanvas, color, topX, topY, topX, topY + height);
            DrawLine(drawCanvas, color, topX, topY + height, topX + width, topY + height);
            DrawLine(drawCanvas, color, topX, endY : 50);
        }

        private void DrawLine(Canvas drawCanvas, SolidColorBrush color, 
                                int startX, int startY = 10, int endX = 20, int endY = 30)
        {
            
            Line line= new Line();
            line.X1 = startX; line.Y1 = startY;
            line.X2 = endX; line.Y2 = endY;
            line.Stroke = color;
            line.StrokeThickness = 1;
            drawCanvas.Children.Add(line);
        }
    }
}
