using System.Windows;

namespace TravelPal.Pages
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();

            // fill Combobox with Both Enums PopulateComboBox()
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            // fill Combobox with Both Enums PopulateComboBox()

        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {


            // Read textboxes
            // create User and add to UserManager

            // warning if username already exists
            if (txtPassword.Password == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Warning!");
            }
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
