using System.Windows;


namespace DataGridExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Create a new Employee Record
            //Instatiate a new Employee Object and give it information
            Employee johnSmith = new Employee();

            //Add some details about John Smith
            johnSmith.employeeID = "001";
            johnSmith.employeeName = "John Smith";
            johnSmith.employeeAdress = "122 Made up Lane";
            johnSmith.employeeCity = "Camden";
            johnSmith.employeeState = "New Jersey";

            DataGridXAML.Items.Add(johnSmith);

            Employee sallyMae = new Employee();

            //Add some details about sally Mae
            sallyMae.employeeID = "002";
            sallyMae.employeeName = "Sally Mae";
            sallyMae.employeeAdress = "Grove street";
            sallyMae.employeeCity = "Harlem";
            sallyMae.employeeState = "New York";

            DataGridXAML.Items.Add(sallyMae);
            
        }

        public class Employee
        {
            public string employeeID { get; set; }
            public string employeeName { get; set; }
            public string employeeAdress { get; set; }
            public string employeeCity { get; set; }
            public string employeeState { get; set; }
        }

        private void AddNewEmployeeBN_Clicked(object sender, RoutedEventArgs e)
        {
            Employee tempEmployee = new Employee();
            tempEmployee.employeeID = IDTB.Text;
            tempEmployee.employeeName = NameTB.Text;
            tempEmployee.employeeAdress = AddrTB.Text;
            tempEmployee.employeeCity = CityTB.Text;
            tempEmployee.employeeState = StateTB.Text;

            DataGridXAML.Items.Add(tempEmployee);
        }

        private void DataGridXAML_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
