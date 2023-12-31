﻿using System.Windows;
using TravelPal.Interfaces;
using TravelPal.Pages;
using TravelPal.Repos;

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



            if (UserManager.SignInUser(username))
            {
                MessageBox.Show("Please enter a valid username", "WARNING!");
                txtPassword.Password = "";
                txtUsername.Text = "";
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password");
            }
            else if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(username))
            {
                foreach (IUser user in Repos.UserManager.Users)
                {

                    if (user.Password == password && user.Username == username)
                    {
                        Repos.UserManager.SignedInUser = user;

                        TravelsWindow travelsWindow = new(user);
                        travelsWindow.Show();
                        Close();
                        break;

                    }
                }
                if (Repos.UserManager.SignedInUser == null)
                {
                    MessageBox.Show("Incorrect password", "Warning!");
                }
            }
        }
    }
}
