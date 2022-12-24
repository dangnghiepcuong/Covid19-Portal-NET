namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Organization
    {
        private string id;
        private string name;
        private string provincename;
        private string districtname;
        private string townname;
        private string street;

        //Constructor
        public Organization()
        {
            id = "";
            name = "";
            provincename = "";
            districtname = "";
            townname = "";
            street = "";
        }

        //Getter, Setter
        public string Id { get; set; }
        public string Name { get; set; }
        public string ProvinceName { get; set; }
        public string DistrictName { get; set; }
        public string TownName { get; set; }
        public string Street { get; set; }
    }
}
