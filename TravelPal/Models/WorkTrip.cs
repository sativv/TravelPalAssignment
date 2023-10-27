using TravelPal.Enums;
using TravelPal.Interfaces;

namespace TravelPal.Models
{
    public class WorkTrip : Travel
    {
        public string MeetingDetails { get; set; }

        public WorkTrip(string destination, Country countries, int travellers, string meetingDetails, User ownedUser) : base(destination, countries, travellers, ownedUser)
        {
            Destination = destination;
            Countries = countries;
            Travellers = travellers;
            MeetingDetails = meetingDetails;

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
            return $"Going to {Destination} from {Countries}- there are {Travellers} {peoplePersons} travelling | {MeetingDetails} ";
        }
    }
}
