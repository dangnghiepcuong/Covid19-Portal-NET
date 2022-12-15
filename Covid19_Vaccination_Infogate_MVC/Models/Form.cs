using System;

namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Form
    {
        private Citizen citizen;
        private DateTime FilledDate;
        private String Choice;
        private int ID;

        //Constructor
        public Form()
        {
            this.citizen = new Citizen();
            Choice = "";
            ID = -1;
        }

        //Getter,Setter
        public Citizen Citizen { get => citizen; set => citizen = value; }
        public DateTime FilledDate1 { get => FilledDate; set => FilledDate = value; }
        public string Choice1 { get => Choice; set => Choice = value; }
        public int ID1 { get => ID; set => ID = value; }
    }
}
