using System.Collections.Generic;
using TravelPal.Interfaces;
using TravelPal.Models;

namespace TravelPal.Repos
{
    public static class TravelManager
    {
        public static List<Travel> Travels { get; set; } = new List<Travel>() { new WorkTrip("Bangkok", Enums.Country.Thailand, 2, "Business Meeting", (User)UserManager.Users[1], new List<IPackingListItem>() { new OtherItem("Toothbrush"), new OtherItem("Medicine"), new OtherItem("Socks") }), new Vacation("Helsingborg", Enums.Country.Sweden, 1, true, (User)UserManager.Users[1], new List<IPackingListItem>() { new OtherItem("Wallet"), new OtherItem("Hand cream"), new OtherItem("Medicine") }) };


    }
}
