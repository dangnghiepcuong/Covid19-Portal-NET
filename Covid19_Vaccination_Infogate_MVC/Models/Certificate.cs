namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Certificate
    {
        private Citizen citizen;
        private int Dose;
        private int CertType;


        //Constructor
        public Certificate()
        {
            this.Citizen = new Citizen();
            Dose1 = -1;
            CertType1 = -1;
        }

        //Getter, Setter
        public Citizen Citizen { get => citizen; set => citizen = value; }
        public int Dose1 { get => Dose; set => Dose = value; }
        public int CertType1 { get => CertType; set => CertType = value; }
    }
}
