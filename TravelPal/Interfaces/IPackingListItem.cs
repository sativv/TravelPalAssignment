namespace TravelPal.Interfaces
{
    public interface IPackingListItem
    {
        public string Name { get; set; }


        public string GetInfo();
    }



    class TravelDocument : IPackingListItem
    {
        public string Name { get; set; }

        public bool Required { get; set; }

        public string GetInfo()
        {
            return "";
        }
    }

    class OtherItem : IPackingListItem
    {
        public string Name { get; set; }

        public string GetInfo()
        {
            return "";
        }
    }
}
