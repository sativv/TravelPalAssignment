using TravelPal.Enums;

namespace TravelPal.Models
{
    public class WorkTrip : Travel
    {
        public string MeetingDetails { get; set; }

        public WorkTrip(string destination, Country countries, int travellers, int travelDays, string MeetingDetails) : base(destination, countries, travellers, travelDays)
        {
        }




        public string GetInfo()
        {
            return "";
        }
    }
}
