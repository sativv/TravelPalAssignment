using System;
using System.Windows;
using TravelPal.Enums;
using TravelPal.Interfaces;
using TravelPal.Repos;

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


            FillComboBox();
        }

        private void FillComboBox()
        {
            // fill Combobox with Both Enums FillComboBox()
            cbCountry.ItemsSource = Enum.GetValues(typeof(Country));
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {


            // Read textboxes



            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter a username");
                return;
            }
            else if (txtPassword.Password == "")
            {
                MessageBox.Show("Please enter a password");
                return;
            }
            else if (cbCountry.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a country");
                return;
            }



            string username = txtUsername.Text;
            string password = txtPassword.Password;
            Country location = (Country)cbCountry.SelectedValue;
            if (UserManager.AddUser(new User(username, password, location)))
            {

                // Prompt successful login
                MessageBox.Show("User Created! Welcome to TravelPal", "Success");
                // return to login window
                MainWindow mainWindow1 = new MainWindow();
                mainWindow1.Show();
                Close();

            }
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            Close();
        }
    }
}
