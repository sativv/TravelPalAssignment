using System.Collections.Generic;
using TravelPal.Models;

namespace TravelPal.Repos
{
    public interface TravelManager
    {
        public List<Travel> Travels { get; set; }

        public void addTravel(Travel travel)
        {
            Travels.Add(travel);
        }

        public void removeTravel(Travel travel)
        {
            Travels.Remove(travel);
        }
    }
}
