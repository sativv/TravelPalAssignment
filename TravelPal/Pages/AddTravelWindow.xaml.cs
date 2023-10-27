using System;
using System.Collections.Generic;
using System.Windows;
using TravelPal.Enums;
using TravelPal.Interfaces;
using TravelPal.Models;
using TravelPal.Repos;

namespace TravelPal.Pages
{
    /// <summary>
    /// Interaction logic for AddTravelWindow.xaml
    /// </summary>
    public partial class AddTravelWindow : Window
    {
        List<string> travelSubclasses = new List<string> { "Vacation", "Worktrip" };
        public AddTravelWindow()
        {

            InitializeComponent();
            FillComboBoxes();








        }

        private void btnAddTravel_Click(object sender, RoutedEventArgs e)
        {

            if (txtCity.Text == "" || cbCountry.SelectedIndex == -1 || txtTravellersNo.Text == "" || cbTripType.SelectedIndex == -1)
            {
                MessageBox.Show("You are required to fill all fields!", "WARNING!");
            }

            string City = txtCity.Text;
            Country country = (Country)cbCountry.SelectedItem;
            int travellersNo = Int32.Parse(txtTravellersNo.Text);
            string? tripType = cbTripType.SelectedItem.ToString();
            bool allInclusive = false;
            string? meetingDetails = txtMeetingDetails.Text;




            if (checkAllInclusive.IsChecked == true)
            {
                allInclusive = true;


            }



            if (cbTripType.SelectedIndex == 1)
            {
                WorkTrip newWorkTrip = new(City, country, travellersNo, meetingDetails, (User)UserManager.SignedInUser);
                TravelManager.Travels.Add(newWorkTrip);
                ReturnWindow();
            }
            else if (cbTripType.SelectedIndex == 0)
            {
                Vacation newVacaton = new(City, country, travellersNo, allInclusive, (User)UserManager.SignedInUser);
                TravelManager.Travels.Add(newVacaton);
                ReturnWindow();

            }

        }
        private void FillComboBoxes()
        {
            // fill Combobox with Enum FillComboBox()
            cbCountry.ItemsSource = Enum.GetValues(typeof(Country));
            cbTripType.SelectedIndex = -1;
            cbTripType.ItemsSource = travelSubclasses;





        }

        private void cbTripType_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (cbTripType.SelectedIndex == 1)
            {
                lblMeetingDetails.Visibility = Visibility.Visible;
                txtMeetingDetails.Visibility = Visibility.Visible;
                lblAllInclusive.Visibility = Visibility.Hidden;
                checkAllInclusive.Visibility = Visibility.Hidden;
            }
            else if (cbTripType.SelectedIndex == 0)
            {
                lblAllInclusive.Visibility = Visibility.Visible;
                checkAllInclusive.Visibility = Visibility.Visible;
                lblMeetingDetails.Visibility = Visibility.Hidden;
                txtMeetingDetails.Visibility = Visibility.Hidden;
            }
            else
            {
                lblMeetingDetails.Visibility = Visibility.Hidden;
                txtMeetingDetails.Visibility = Visibility.Hidden;
                lblAllInclusive.Visibility = Visibility.Hidden;
                checkAllInclusive.Visibility = Visibility.Hidden;
            }


        }

        //private void ClearFields()
        //{
        //    txtCity.Text = "";
        //    txtMeetingDetails.Text = "";
        //    txtTravellersNo.Text = "";
        //}

        private void ReturnWindow()
        {
            TravelsWindow travelsWindow = new(UserManager.SignedInUser);
            travelsWindow.Show();
            Close();
        }

        private void checkTravelDocument_Checked(object sender, RoutedEventArgs e)
        {

            checkTravelDocumentRequired.Visibility = Visibility.Visible;
            lblRequired.Visibility = Visibility.Visible;

        }

        private void checkTravelDocument_Unchecked(object sender, RoutedEventArgs e)
        {
            checkTravelDocumentRequired.Visibility = Visibility.Hidden;
            lblRequired.Visibility = Visibility.Hidden;
        }

        private void cbCountry_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            foreach (var country in Enum.GetValues(typeof(EuropeanCountry)))
            {
                if (UserManager.SignedInUser.Location == (Country)country)
                {

                }
            }
        }
    }



}
