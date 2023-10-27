using System.Windows;
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


        public TravelDetailsWindow(Travel travel, IUser user)
        {

            InitializeComponent();


            // figure out why this does not work
            txtCity.Text = travel.Destination.ToString();
            txtTravellersNo.Text = travel.Travellers.ToString();
            cbCountry.Text = travel.Countries.ToString();
            cbTripType.Text = travel.GetType().Name;

            if (travel.GetType().Name == "Worktrip")
            {
                txtMeetingDetails.Visibility = Visibility.Visible;
                lblMeetingDetails.Visibility = Visibility.Visible;

            }
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            TravelsWindow travelsWindow = new(UserManager.SignedInUser);
            travelsWindow.Show();
            Close();
        }
    }
}
