using System.Reflection.Metadata;

namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Register
    {
        private Citizen citizen = new Citizen();
        private Schedule sched = new Schedule();
        private int time;
        private int no;
        private int status;
        private byte[]? image;
        private string dosetype;
        private int id;
        
        //Constructor
        public Register()
        {
            citizen = new Citizen();
            sched = new Schedule();
            time = -1;
            no = -1;
            status = -1;
            dosetype = "";
            id = -1;
        }

        //Getter, Setter
        public Citizen Citizen { get; set; }
        public Schedule Sched { get; set; }
        public int Time { get; set; }
        public int No { get; set; }
        public int Status { get; set; }
        public byte[] Image { get; set; }
        public string DoseType { get; set; }
        public int Id { get; set; }
    }
}
