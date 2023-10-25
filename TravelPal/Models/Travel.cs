using TravelPal.Enums;

namespace TravelPal.Models
{
    public class Travel
    {
        public string Destination { get; set; }
        public Country Countries { get; set; }
        public int Travellers { get; set; }
        //public List<PackingListItem> PackingList { get; 


        public Travel(string destination, Country countries, int travellers)
        {
            Destination = destination;
            Countries = countries;
            Travellers = travellers;

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
