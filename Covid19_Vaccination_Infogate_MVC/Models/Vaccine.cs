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

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Technology { get => technology; set => technology = value; }
        public string Country { get => country; set => country = value; }

      


    }
}
