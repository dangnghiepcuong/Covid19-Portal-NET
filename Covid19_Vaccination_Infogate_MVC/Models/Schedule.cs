using System;

namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Schedule
    {
        private string id;
        private Organization org;
        private string ondate;
        private Vaccine vaccine;
        private string serial;
        private int limitday;
        private int limitnoon;
        private int limitnight;
        private int dayregister;
        private int noonregister;
        private int nightregister;

        public Schedule()
        {
            id = "";
            ondate = "";
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
        public string OnDate { get; set; }
        public Vaccine Vaccine { get; set; }
        public string Serial { get; set; }
        public int LimitDay { get; set; }
        public int LimitNoon { get; set; }
        public int LimitNight { get; set; }
        public int DayRegistered { get; set; }
        public int NoonRegistered { get; set; }
        public int Nightregistered { get; set; }
    }
}
