using System;
namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Injection
    {
        private Citizen citizen = new Citizen();
        private int injno;
        private Schedule sched;
        private string dosetype;

        //Constructor
        public Injection()
        {
            citizen = new Citizen();
            injno = -1;
            sched = new Schedule();
            dosetype = "";
        }

        //Getter, setter
        public Citizen Citizen { get ; set; }
        public int InjNO { get ; set ; }
        public Schedule Sched { get ; set; }
        public string DoseType { get; set; }
    }
}
