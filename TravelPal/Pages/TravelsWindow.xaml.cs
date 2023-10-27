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
            lstTravelList.Items.Clear();

            foreach (Travel travel in TravelManager.Travels)
            {

                if (travel.OwnedUser.Username == UserManager.SignedInUser.Username)
                {

                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Tag = travel;
                    listViewItem.Content = "Destination - " + travel.Countries.ToString() + " - " + travel.GetType().Name;
                    lstTravelList.Items.Add(listViewItem);
                }
                else if (UserManager.SignedInUser is Admin)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Tag = travel;
                    listViewItem.Content = "Destination - " + travel.Countries.ToString() + " - " + travel.GetType().Name + " - " + travel.OwnedUser.Username;
                    lstTravelList.Items.Add(listViewItem);
                }



            }
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem listViewItemToEdit = (ListViewItem)lstTravelList.SelectedItem;
            TravelDetailsWindow detailsWindow = new TravelDetailsWindow((Travel)listViewItemToEdit.Tag, UserManager.SignedInUser);
            detailsWindow.Show();
            Close();
        }

        private void lstTravelList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            btnRemove.IsEnabled = true;
            btnDetails.IsEnabled = true;



        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {

            // Why does this not work?
            ListViewItem selectedItem = (ListViewItem)lstTravelList.SelectedItem;
            TravelManager.Travels.Remove((Travel)selectedItem.Tag);
            FillTravelList();

        }
    }
}
