namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Organization
    {
        private string ID;
        private string Name;
        private string ProvinceName;
        private string DistrictName;
        private string TownName;
        private string Street;

        //Constructor
        public Organization()
        {
            ID = "";
            Name = "";
            ProvinceName = "";
            DistrictName = "";
            TownName = "";
            Street = "";
        }

        //Getter, Setter
        public string ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string ProvinceName1 { get => ProvinceName; set => ProvinceName = value; }
        public string DistrictName1 { get => DistrictName; set => DistrictName = value; }
        public string TownName1 { get => TownName; set => TownName = value; }
        public string Street1 { get => Street; set => Street = value; }
    }
}
