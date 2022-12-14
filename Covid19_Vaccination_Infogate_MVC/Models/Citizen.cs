using System;
using System.Reflection.Metadata;

namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Citizen
    {
        private String ID;
        private String LastName;
        private String FirstName;
        private DateTime Birthday;
        private int Gender;
        private String HomeTown;
        private String ProvinceName;
        private String DistrictName;
        private String TownName;
        private String Street;
        private String Phone;
        private String Email;
        private String Guadian;
        private Blob Avatar;

        //Constructor
        public Citizen()
        {
            Gender1 = -1;
        }

        //Getter, setter
        public string ID1 { get => ID; set => ID = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public DateTime Birthday1 { get => Birthday; set => Birthday = value; }
        public int Gender1 { get => Gender; set => Gender = value; }
        public string HomeTown1 { get => HomeTown; set => HomeTown = value; }
        public string ProvinceName1 { get => ProvinceName; set => ProvinceName = value; }
        public string DistrictName1 { get => DistrictName; set => DistrictName = value; }
        public string TownName1 { get => TownName; set => TownName = value; }
        public string Street1 { get => Street; set => Street = value; }
        public string Phone1 { get => Phone; set => Phone = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Guadian1 { get => Guadian; set => Guadian = value; }
        public Blob Avatar1 { get => Avatar; set => Avatar = value; }



    }
}
