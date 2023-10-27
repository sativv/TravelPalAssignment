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

        public TravelDocument(string name, bool required)
        {
            Name = name;
            Required = required;
        }

        public string GetInfo()
        {
            if (Required)
            {


                return $"{Name} - Required";
            }
            return Name;
        }
    }

    class OtherItem : IPackingListItem
    {
        public string Name { get; set; }

        public OtherItem(string name)
        {
            Name = name;
        }

        public string GetInfo()
        {
            return $"{Name}";
        }
    }
}
