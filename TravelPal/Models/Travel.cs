using System.Collections.Generic;
using TravelPal.Enums;
using TravelPal.Interfaces;

namespace TravelPal.Models
{
    public class Travel
    {
        public string Destination { get; set; }
        public Country Countries { get; set; }
        public int Travellers { get; set; }

        // set default trip owner to User(1) 
        //public User OwnedUser { get; set; } = (User)UserManager.Users[1];
        public User OwnedUser { get; set; }
        public List<IPackingListItem> packingList { get; set; }

        public Travel(string destination, Country countries, int travellers, User ownedUser)
        {
            Destination = destination;
            Countries = countries;
            Travellers = travellers;
            OwnedUser = ownedUser;



        }


        public string GetInfo()
        {

            string peoplePersons = "";

            if (Travellers < 1)
            {
                peoplePersons = "people";
            }
            else
            {
                peoplePersons = "person";
            }
            return $"You are {Travellers} {peoplePersons} going from {Countries} to {Destination}";

        }

    }
}
