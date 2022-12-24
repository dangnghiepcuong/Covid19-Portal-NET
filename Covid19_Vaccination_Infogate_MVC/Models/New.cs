using System;
using System.Reflection.Metadata;

namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class New
    {
        private string id;
        private Organization org;
        private string tittle;
        private DateTime publishdate;
        private Blob image;
        private string content;


        //Constructor
        public New()
        {
            id = "";
            org = new Organization();
            tittle = "";
            content = "";
        }

        //Getter, Setter
        public string ID { get; set ; }
        public Organization Org { get ; set; }
        public string Tittle { get; set; }
        public DateTime PublishDate { get; set; }
        public Blob Image { get ; set ; }
        public string Content { get ; set ; }
    }
}
