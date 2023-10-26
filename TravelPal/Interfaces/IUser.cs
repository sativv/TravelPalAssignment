﻿using System.Collections.Generic;
using TravelPal.Enums;
using TravelPal.Models;

namespace TravelPal.Interfaces
{
    public interface IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Country Location { get; set; }


    }


    public class User : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Country Location { get; set; }

        public List<Travel> userTravels { get; set; }

        public User(string username, string password, Country location)
        {
            Username = username;
            Password = password;
            Location = location;

        }





    }



    public class Admin : IUser
    {
        public List<Travel> Travels { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Country Location { get; set; }

        public Admin(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
