namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Certificate
    {
        private Citizen citizen;
        private int dose;
        private int certtype;


        //Constructor
        public Certificate()
        {
            this.citizen = new Citizen();
            dose = -1;
            certtype = -1;
        }

        //Getter, Setter
        public Citizen Citizen { get ; set ; }
        public int Dose { get  ; set  ; }
        public int CertType { get ; set ; }
    }
}
