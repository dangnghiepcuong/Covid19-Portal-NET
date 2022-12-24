using System;

namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Form
    {
        private Citizen citizen;
        private DateTime filleddate;
        private String choice;
        private int id;

        //Constructor
        public Form()
        {
            this.citizen = new Citizen();
            choice = "";
            id = -1;
        }

        //Getter,Setter
        public Citizen Citizen { get ; set ; }
        public DateTime FilledDate { get ; set ; }
        public string Choice { get ; set ; }
        public int ID { get ; set ; }
    }
}
