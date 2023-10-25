using System.Windows;
using TravelPal.Interfaces;
using TravelPal.Pages;

namespace TravelPal
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

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerwindow = new RegisterWindow();
            registerwindow.Show();
            Close();
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {


            string password = txtPassword.Password;
            string username = txtUsername.Text;

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password");
            }
            else if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username");

            }
            else if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(username))
            {
                foreach (IUser user in Repos.UserManager.Users)
                {
                    if (user.Password == password && user.Username == username)
                    {
                        Repos.UserManager.SignedInUser = user;
                        break;

                    }
                }
            }
        }
    }
}
