using System;
using System.Collections.Generic;
using TravelPal.Enums;
using TravelPal.Interfaces;
using TravelPal.Models;

namespace TravelPal.Repos
{
    class UserManager
    {
        public static List<IUser> Users { get; set; } = new List<IUser>() { new Admin("admin", "password"), new User("user", "password", Country.Thailand) };
        public static IUser? SignedInUser { get; set; }



        public bool AddUser(IUser user)
        {
            if (ValidateUsername(user.Username))
            {
                Users.Add(user);
            }
            return true;
        }

        public void RemoveUser(IUser user)
        {

        }

        public bool UpdateUsername(IUser user, string username)
        {
            return true;
        }

        private bool ValidateUsername(string username)
        {
            foreach (var user in Users)
            {
                if (user.Username == username)
                {
                    return false;
                }
            }
            return true;
        }

        public bool SignInUser(string username, string password)
        {
            return true;
        }





        public class User : IUser
        {
            public string Username { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public Country Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public EuropeanCountry LocationEU { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public User(string username, string password, Country location)
            {
                Username = username;
                Password = password;
                Location = location;

            }

            public User(string username, string password, EuropeanCountry location)
            {
                Username = username;
                Password = password;
                LocationEU = location;
            }



        }



        public class Admin : IUser
        {
            public List<Travel> Travels { get; set; }
            public string Username { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public Country Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public Admin(string username, string password)
            {
                Username = username;
                Password = password;
            }
        }
    }
}
