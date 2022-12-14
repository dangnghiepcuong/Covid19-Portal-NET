using System;
namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Injection
    {
        private Citizen citizen;
        private int InjNO;
        private Schedule Sched;
        private String DoseType;

        //Constructor
        public Injection()
        {
            this.citizen = new Citizen();
            InjNO = -1;
            Sched = new Schedule();
            DoseType = "";
        }

        //Getter, setter
        public Citizen Citizen { get => citizen; set => citizen = value; }
        public int InjNO1 { get => InjNO; set => InjNO = value; }
        public Schedule Sched1 { get => Sched; set => Sched = value; }
        public string DoseType1 { get => DoseType; set => DoseType = value; }
    }
}
