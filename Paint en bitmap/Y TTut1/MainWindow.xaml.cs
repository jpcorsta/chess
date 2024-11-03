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

namespace Y_TTut1
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

        private void testButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello world");
        }

        private void tekenKnop_Click(object sender, RoutedEventArgs e)
        {
             
            Ellipse ellipse = new Ellipse();
            ellipse.Width = 100;
            ellipse.Height = 120;
            ellipse.Margin = new Thickness(10, 80, 0, 0);
            ellipse.Stroke = new SolidColorBrush(Colors.Black);
            tekenCanvas.Children.Add(ellipse);

            Ellipse ellipseTwo = new Ellipse();
            ellipseTwo.Width = 19;
            ellipseTwo.Height = 8;
            ellipseTwo.Margin = new Thickness(30, 120, 0, 0);
            ellipseTwo.Fill = new SolidColorBrush(Colors.White);
            tekenCanvas.Children.Add(ellipseTwo);

            Ellipse ellipsThree = new Ellipse();
            ellipsThree.Width = 19;
            ellipsThree.Height = 8; 
            ellipsThree.Margin = new Thickness(70, 120, 0, 0);
            ellipsThree.Fill = new SolidColorBrush(Colors.White);
            tekenCanvas.Children.Add(ellipsThree);

            Ellipse ellipseFor = new Ellipse();
            ellipseFor.Width = 2;
            ellipseFor.Height = 2;
            ellipseFor.Margin = new Thickness(37, 122, 0, 0);
            ellipseFor.Fill = new SolidColorBrush(Colors.Black);
            tekenCanvas.Children.Add(ellipseFor);

            Ellipse ellipsFive = new Ellipse();
            ellipsFive.Width = 2;
            ellipsFive.Height = 2;
            ellipsFive.Margin = new Thickness(78, 122, 0, 0);
            ellipsFive.Fill = new SolidColorBrush(Colors.Black);
            tekenCanvas.Children.Add(ellipsFive);

            Ellipse ellipsSix = new Ellipse();
            ellipsSix.Width = 5;
            ellipsSix.Height = 5;
            ellipsSix.Margin = new Thickness(56, 140, 0, 0);
            ellipsSix.Fill = new SolidColorBrush(Colors.Red);
            tekenCanvas.Children.Add(ellipsSix);

            Line mouth = new Line();
            mouth.X1 = 51; mouth.Y1 = 160;
            mouth.X2 = 64; mouth.Y2 = 160;
            mouth.Stroke= new SolidColorBrush(Colors.Peru);
            tekenCanvas.Children.Add(mouth);

            Line mouthLeft = new Line();
            mouthLeft.X1 = 51; mouthLeft.Y1 = 160;
            mouthLeft.X2 = 46; mouthLeft.Y2 = 155;
            mouthLeft.Stroke = new SolidColorBrush(Colors.Peru);
            tekenCanvas.Children.Add(mouthLeft);

            Line mouthRigth = new Line();
            mouthRigth.X1 = 64; mouthRigth.Y1 = 160;
            mouthRigth.X2 = 69; mouthRigth.Y2 = 155;
            mouthRigth.Stroke = new SolidColorBrush(Colors.Peru);
            tekenCanvas.Children.Add(mouthRigth);


        }

        public void FillEllipseWithPathGradient(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, 140, 70);
        }

    }
}
