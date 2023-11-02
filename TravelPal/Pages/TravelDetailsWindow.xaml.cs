using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using TravelPal.Enums;
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
        List<string> travelSubclasses = new List<string> { "Vacation", "Worktrip" };

        Travel currentTravel { get; set; }

        public TravelDetailsWindow(Travel travel, IUser user)
        {
            currentTravel = travel;
            InitializeComponent();
            FillList();
            FillComboBoxes();


            txtCity.Text = travel.Destination.ToString();
            txtTravellersNo.Text = travel.Travellers.ToString();
            cbCountry.SelectedValue = travel.Countries;

            if (travel is Vacation)
            {
                cbTripType.SelectedIndex = 0;
            }
            else if (travel is WorkTrip)
            {
                cbTripType.SelectedIndex = 1;
            }

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


        private void FillComboBoxes()
        {
            // fill Combobox with Enum FillComboBox()
            cbCountry.ItemsSource = Enum.GetValues(typeof(Country));
            cbTripType.SelectedIndex = -1;
            cbTripType.ItemsSource = travelSubclasses;





        }





        //private void btnEdit_Click(object sender, RoutedEventArgs e)
        //{
        //    cbTripType.IsEnabled = true;
        //    cbCountry.IsEnabled = true;
        //    txtCity.IsEnabled = true;
        //    txtMeetingDetails.IsEnabled = true;
        //    txtTravellersNo.IsEnabled = true;
        //    checkAllInclusive.IsEnabled = true;
        //    btnEdit.Visibility = Visibility.Hidden;
        //    btnSave.Visibility = Visibility.Visible;

        //}

        //private void btnSave_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }

}
