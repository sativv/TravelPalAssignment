using System;
using System.Windows;
using System.Windows.Documents;
using TravelPal.Enums;
using TravelPal.Models;

namespace TravelPal.Pages
{
    /// <summary>
    /// Interaction logic for AddTravelWindow.xaml
    /// </summary>
    public partial class AddTravelWindow : Window
    {
        public AddTravelWindow()
        {
            List < Travel > = new();
            InitializeComponent();
            FillComboBoxes();
        }

        private void btnAddTravel_Click(object sender, RoutedEventArgs e)
        {
            string City = txtCity.Text;
            Country country = (Country)cbCountry.SelectedItem;
            int travellersNo = Int32.Parse(txtTravellersNo.Text);
            string? tripType = cbTripType.SelectedItem.ToString();
            bool allInclusive = false;

            if (checkAllInclusive.IsChecked == true)
            {
                allInclusive = true;


            }

            Travel travel = new(City, country, travellersNo);

        }
        private void FillComboBoxes()
        {
            // fill Combobox with Enum FillComboBox()
            cbCountry.ItemsSource = Enum.GetValues(typeof(Country));

        }

        private void FillTravelList()
        {
            foreach ()
        }
    }



}
