using TravelPal.Interfaces;

namespace TravelPal.Models
{
    class TravelDocument : IPackingListItem
    {
        public string Name { get; set; }

        public bool Required { get; set; }


    }
}
