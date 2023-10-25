using System.Windows;
using TravelPal.Interfaces;
using TravelPal.Repos;

namespace TravelPal.Pages
{
    /// <summary>
    /// Interaction logic for TravelsWindow.xaml
    /// </summary>
    public partial class TravelsWindow : Window
    {
        public TravelsWindow(IUser user)
        {
            InitializeComponent();
            lblUsername.Content = user.Username;
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            UserManager.SignedInUser = null;
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void btnAddTravel_Click(object sender, RoutedEventArgs e)
        {
            AddTravelWindow addTravelWindow = new();
            addTravelWindow.Show();
            Close();
        }
    }
}
