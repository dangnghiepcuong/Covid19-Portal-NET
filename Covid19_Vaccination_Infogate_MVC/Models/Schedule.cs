using System;

namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Schedule
    {
        private String ID;
        private Organization Org;
        private DateTime OnDate;
        private Vaccine Vaccine;
        private String Serial;
        private int LimitDay;
        private int LimitNoon;
        private int LimitNight;
        private int DayRegister;
        private int NoonRegister;
        private int NightRegister;

        public Schedule()
        {
            ID = "";
            Org = new Organization();
            Vaccine = new Vaccine();
            Serial = "";
            LimitDay = 0;
            LimitNoon = 0;
            LimitNight = 0;
            DayRegister = 0;
            NoonRegister = 0;
            NightRegister = 0;
        }
    }
}
