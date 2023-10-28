using System.Windows;
using System.Windows.Controls;
using TravelPal.Interfaces;
using TravelPal.Models;
using TravelPal.Repos;

namespace TravelPal.Pages
{
    /// <summary>
    /// Interaction logic for TravelDetailsWindow.xaml
    /// </summary>
    public partial class TravelDetailsWindow : Window
    {

        Travel currentTravel { get; set; }

        public TravelDetailsWindow(Travel travel, IUser user)
        {
            currentTravel = travel;
            InitializeComponent();
            FillList();


            // figure out why this does not work
            txtCity.Text = travel.Destination.ToString();
            txtTravellersNo.Text = travel.Travellers.ToString();
            cbCountry.Text = travel.Countries.ToString();
            cbTripType.Text = travel.GetType().Name;

            if (travel is Vacation)
            {
                Vacation vacation = (Vacation)travel;
                checkAllInclusive.IsChecked = vacation.AllInclusive;
                checkAllInclusive.Visibility = Visibility.Visible;
                lblAllInclusive.Visibility = Visibility.Visible;
            }


            if (travel is WorkTrip)
            {
                txtMeetingDetails.Visibility = Visibility.Visible;
                lblMeetingDetails.Visibility = Visibility.Visible;

                WorkTrip workTrip = (WorkTrip)travel;
                txtMeetingDetails.Text = workTrip.MeetingDetails.ToString();
            }

        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            TravelsWindow travelsWindow = new(UserManager.SignedInUser);
            travelsWindow.Show();
            Close();
        }
        public void FillList()
        {
            lstPackingList.Items.Clear();
            foreach (IPackingListItem item in currentTravel.PackingList)
            {
                ListViewItem packingListItem = new ListViewItem();
                packingListItem.Tag = item;
                packingListItem.Content = item.GetInfo();
                lstPackingList.Items.Add(packingListItem);
            }
        }
    }

}
