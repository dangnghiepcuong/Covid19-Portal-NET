using System;
using System.Reflection.Metadata;

namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class New
    {
        private string ID;
        private Organization Org;
        private string Tittle;
        private DateTime PublishDate;
        private Blob Image;
        private string Content;


        //Constructor
        public New()
        {
            ID = "";
            Org = new Organization();
            Tittle = "";
            Content = "";
        }

        //Getter, Setter
        public string ID1 { get => ID; set => ID = value; }
        public Organization Org1 { get => Org; set => Org = value; }
        public string Tittle1 { get => Tittle; set => Tittle = value; }
        public DateTime PublishDate1 { get => PublishDate; set => PublishDate = value; }
        public Blob Image1 { get => Image; set => Image = value; }
        public string Content1 { get => Content; set => Content = value; }
    }
}
