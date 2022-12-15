using System.Reflection.Metadata;

namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Register
    {
        private Citizen Citizen;
        private Schedule Sched;
        private int Time;
        private int NO;
        private int Status;
        private Blob Image;
        private string DoseType;
        private int ID;
        
        //Constructor
        public Register()
        {
            Citizen = new Citizen();
            Sched = new Schedule();
            Time = -1;
            NO = -1;
            Status = -1;
            DoseType = "";
            ID = -1;
        }

        //Getter, Setter
        public Citizen Citizen1 { get => Citizen; set => Citizen = value; }
        public Schedule Sched1 { get => Sched; set => Sched = value; }
        public int Time1 { get => Time; set => Time = value; }
        public int NO1 { get => NO; set => NO = value; }
        public int Status1 { get => Status; set => Status = value; }
        public Blob Image1 { get => Image; set => Image = value; }
        public string DoseType1 { get => DoseType; set => DoseType = value; }
        public int ID1 { get => ID; set => ID = value; }
    }
}
