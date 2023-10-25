using TravelPal.Enums;

namespace TravelPal.Models
{
    class Vacation : Travel
    {
        public bool AllInclusive { get; set; } = false;
        public Vacation(string destination, Country countries, int travellers, int travelDays, bool allInclusive) : base(destination, countries, travellers, travelDays)
        {
        }

    }
}
