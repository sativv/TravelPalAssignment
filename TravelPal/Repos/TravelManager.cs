using System.Collections.Generic;
using TravelPal.Interfaces;
using TravelPal.Models;

namespace TravelPal.Repos
{
    public static class TravelManager
    {
        public static List<Travel> Travels { get; set; } = new List<Travel>() { new WorkTrip("Bangkok", Enums.Country.Thailand, 2, "Business Meeting", (User)UserManager.Users[1]), new Vacation("Helsingborg", Enums.Country.Sweden, 1, true, (User)UserManager.Users[1]) };

        public static void addTravel(Travel travel)
        {
            Travels.Add(travel);
        }

        public static void removeTravel(Travel travel)
        {
            Travels.Remove(travel);
        }
    }
}
