using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp29
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

        private async void myButton_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() => 
            {
                var webClient = new HttpClient();
                var html = webClient.GetStringAsync("https://www.youtube.com/watch?v=Wg8mY8RM-xw").Result;
            });

            MyButton.Content = "qq";
        }

        private void MyButton_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}