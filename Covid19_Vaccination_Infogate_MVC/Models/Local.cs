using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class LocalTown
    {
        string id;
        string name;
        string prefix;

        public string Id { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }
    }

    public class LocalDistrict
    {
        string id;
        string name;
        LocalTown[] wards;

        public string Id { get; set; }
        public string Name { get; set; }
        public LocalTown[] Wards { get; set; }
    }

    public class LocalProvince
    {
        string id;
        string code;
        string name;
        LocalDistrict[] districts;
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public LocalDistrict[] Districts { get; set; }

    }
}
