namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Vaccine
    {
        private string id;
        private string name;
        private string technology;
        private string country;

        //Constructor
        public Vaccine()
        {
            id = "";
            name = "";
            technology = "";
            country = "";
        }

        //Getter, Setter
        public string Id { get; set; }
        public string Name { get; set; }
        public string Technology { get; set; }
        public string Country { get; set; }
    }
}
