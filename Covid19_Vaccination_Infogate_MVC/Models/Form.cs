using System;

namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Form
    { 
        private Citizen citizen = new Citizen();
        private string filleddate;
        private string choice;
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
        public string FilledDate { get ; set ; }
        public string Choice { get ; set ; }
        public int ID { get ; set ; }
    }
}
