namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Vaccine
    {
        private string ID;
        private string Name;
        private string Technology;
        private string Country;

        //Constructor
        public Vaccine()
        {
            ID = "";
            Name = "";
            Technology = "";
            Country = "";
        }

        //Getter, Setter
        public string ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Technology1 { get => Technology; set => Technology = value; }
        public string Country1 { get => Country; set => Country = value; }
    }
}
