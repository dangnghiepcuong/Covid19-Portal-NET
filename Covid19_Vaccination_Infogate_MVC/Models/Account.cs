using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19_Vaccination_Infogate_MVC.Models
{
    public class Account
    {
        private string username;
        private string password;
        private int role;
        private int status;

        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public int Status { get; set; }

        /*public int MyProperty {
            get 
            {
                *//*logic code*//*
                return MyProperty;
            } 
            set
            {
                *//*logic code*//*
                MyProperty = value;
            }
        }*/
    }
}
