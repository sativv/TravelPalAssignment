using System.Windows;
using System.Windows.Controls;
using TravelPal.Interfaces;
using TravelPal.Models;
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
            FillTravelList();
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


        private void FillTravelList()
        {
            foreach (Travel travel in TravelManager.Travels)
            {


                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Tag = travel;
                listViewItem.Content = "Destination - " + travel.Countries.ToString();
                lstTravelList.Items.Add(listViewItem);

            }
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {

            TravelDetailsWindow detailsWindow = new TravelDetailsWindow((Travel)lstTravelList.Tag);
            detailsWindow.Show();
            Close();
        }

        private void lstTravelList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            btnRemove.IsEnabled = true;
            btnDetails.IsEnabled = true;



        }
    }
}
