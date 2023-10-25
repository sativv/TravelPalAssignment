using TravelPal.Enums;

namespace TravelPal.Models
{
    class Vacation : Travel
    {
        public bool AllInclusive { get; set; } = false;
        public Vacation(string destination, Country countries, int travellers, bool allInclusive) : base(destination, countries, travellers)
        {
            Destination = destination;
            Countries = countries;
            Travellers = travellers;
            AllInclusive = allInclusive;
        }


        public string GetInfo()
        {
            string peoplePersons = "";
            string allInclusiveInfo = "";
            if (Travellers < 1)
            {
                peoplePersons = "people";
            }
            else
            {
                peoplePersons = "person";
            }

            if (AllInclusive)
            {
                allInclusiveInfo = " | All Inclusive!";
            }
            return $"Going to {Destination} from {Countries}- there are {Travellers} {peoplePersons} travelling{allInclusiveInfo} ";
        }
    }
}
