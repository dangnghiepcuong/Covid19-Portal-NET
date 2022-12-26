using System.Reflection.Metadata;

namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Register
    {
        //Constructor
        public Register()
        {
            Citizen = new Citizen();
            Sched = new Schedule();
            Time = -1;
            No = -1;
            Status = -1;
            DoseType = "";
            Id = -1;
        }

        //Getter, Setter
        public Citizen Citizen { get; set; }
        public Schedule Sched { get; set; }
        public int Time { get; set; }
        public string TimeClock()
        {
            switch (Time)
            {
                case 0: return "08:00";
                case 1: return "13:00";
                case 2: return "19:00";
                default: return "";
            }
            return "";
        }
        public int No { get; set; }
        public int Status { get; set; }
        public byte[]? Image { get; set; }
        public string DoseType { get; set; }
        public int Id { get; set; }
    }
}
