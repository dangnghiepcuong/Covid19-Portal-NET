using System;

namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Schedule
    {
        private String id;
        private Organization org;
        private DateTime ondate;
        private Vaccine vaccine;
        private String serial;
        private int limitday;
        private int limitnoon;
        private int limitnight;
        private int dayregister;
        private int noonregister;
        private int nightregister;

        public Schedule()
        {
            id = "";
            org = new Organization();
            vaccine = new Vaccine();
            serial = "";
            limitday = 0;
            limitnoon = 0;
            limitnight = 0;
            dayregister = 0;
            noonregister = 0;
            nightregister = 0;
        }

        public string Id { get; set; }
        public Organization Org { get; set; }
        public DateTime Ondate { get ; set ; }
        public Vaccine Vaccine { get ; set ; }
        public string Serial { get; set ; }
        public int Limitday { get ; set; }
        public int Limitnoon { get ; set; }
        public int Limitnight { get; set ; }
        public int Dayregister { get ; set ; }
        public int Noonregister { get; set; }
        public int Nightregister { get; set; }
    }
}
