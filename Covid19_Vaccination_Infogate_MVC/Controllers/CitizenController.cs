using Covid19_Vaccination_Infogate_MVC.Models;
using Covid19_Vaccination_Infogate_MVC.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Globalization;

namespace Covid19_Vaccination_Infogate_MVC.Controllers
{
    public class CitizenController : Controller
    {
        private readonly ILogger<CitizenController> _logger;

        public CitizenController(ILogger<CitizenController> logger)
        {
            _logger = logger;
        }
        private void LoadCitizenProfile()
        {
            Citizen citizen = new Citizen();
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");

            SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            var conn = new OracleConnection();
            conn.ConnectionString = "User Id=covid19_vaccination_infogate;Password=covid19_vaccination_infogate;Data Source=localhost/orcl";
            conn.Open();

            string query = "select ID, LastName, FirstName, TO_CHAR( Birthday, 'YYYY-MM-DD' ) Birthday, Gender,"
            + "Hometown, ProvinceName, DistrictName, TownName, Street,"
            + "Phone, Email, Guardian, Avatar "
            + "from CITIZEN where Phone= :username";
            var command = new OracleCommand(query, conn);
            command.Parameters.Add(new OracleParameter("username", account.Username));
            var reader = command.ExecuteReader();

            if (reader.HasRows == false)
                return;

            while (reader.Read())
            {
                citizen.LastName = reader["LASTNAME"] as string;
                citizen.FirstName = reader["FIRSTNAME"] as string;
                citizen.Id = reader["ID"] as string;
                string date = reader["BIRTHDAY"] as string;
                citizen.Birthday = reader["BIRTHDAY"] as string;
                citizen.Gender(reader.GetInt32(reader.GetOrdinal("GENDER")));
                citizen.HomeTown = reader["HOMETOWN"] as string;
                citizen.ProvinceName = reader["PROVINCENAME"] as string;
                citizen.DistrictName = reader["DISTRICTNAME"] as string;
                citizen.TownName = reader["TOWNNAME"] as string;
                citizen.Street = reader["STREET"] as string;
                citizen.Phone = reader["PHONE"] as string;
                citizen.Email = reader["EMAIL"] as string;
                citizen.Guadian = reader["GUARDIAN"] as string;
                /*citizen.Avatar = (byte[])reader["AVATAR"];*/
            }
            conn.Close();

            SessionHelper.SetObjectAsJson(HttpContext.Session, "CitizenProfile", citizen);
            return;
        }

        public IActionResult Index()
        {
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            if (account != null && account.Role == 2 && account.Status == 1)
            {
                if (SessionHelper.GetObjectFromJson<Citizen>(HttpContext.Session, "CitizenProfile") == null)
                    LoadCitizenProfile();
                return View();
            }
            else
            {
                Response.Redirect("/Home");
                return Json(new { message = "Redirected to /Home" });
            }

            return Profile();
        }

        public IActionResult MedicalForm()
        {
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            if (account != null && account.Role == 2 && account.Status == 1)
            {
                if (SessionHelper.GetObjectFromJson<Citizen>(HttpContext.Session, "CitizenProfile") == null)
                    LoadCitizenProfile();
                return View();
            }
            else
            {
                Response.Redirect("/Home");
                return Json(new { message = "Redirected to /Home" });
            }
        }

        public IActionResult MedicalFormList()
        {
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            if (account != null && account.Role == 2 && account.Status == 1)
            {
                if (SessionHelper.GetObjectFromJson<Citizen>(HttpContext.Session, "CitizenProfile") == null)
                    LoadCitizenProfile();
                return View();
            }
            else
            {
                Response.Redirect("/Home");
                return Json(new { message = "Redirected to /Home" });
            }
        }

        public IActionResult Vaccination()
        {
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            if (account != null && account.Role == 2 && account.Status == 1)
            {
                if (SessionHelper.GetObjectFromJson<Citizen>(HttpContext.Session, "CitizenProfile") == null)
                    LoadCitizenProfile();
                return View();
            }
            else
            {
                Response.Redirect("/Home");
                return Json(new { message = "Redirected to /Home" });
            }
        }

        public IActionResult AccountInfo()
        {
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            if (account != null && account.Role == 2 && account.Status == 1)
            {
                if (SessionHelper.GetObjectFromJson<Citizen>(HttpContext.Session, "CitizenProfile") == null)
                    LoadCitizenProfile();
                return View();
            }
            else
            {
                Response.Redirect("/Home");
                return Json(new { message = "Redirected to /Home" });
            }
        }

        public IActionResult Profile()
        {
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            if (account != null && account.Role == 2 && account.Status == 1)
            {
                if (SessionHelper.GetObjectFromJson<Citizen>(HttpContext.Session, "CitizenProfile") == null)
                    LoadCitizenProfile();
                return View();
            }
            else
            {
                Response.Redirect("/Home");
                return Json(new { message = "Redirected to /Home" });
            }
        }

        public IActionResult Registration()
        {
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            if (account != null && account.Role == 2 && account.Status == 1)
            {
                if (SessionHelper.GetObjectFromJson<Citizen>(HttpContext.Session, "CitizenProfile") == null)
                    LoadCitizenProfile();
                return View();
            }
            else
            {
                Response.Redirect("/Home");
                return Json(new { message = "Redirected to /Home" });
            }
        }
        public IActionResult Certificate()
        {
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            if (account != null && account.Role == 2 && account.Status == 1)
            {
                if (SessionHelper.GetObjectFromJson<Citizen>(HttpContext.Session, "CitizenProfile") == null)
                    LoadCitizenProfile();
                return View();
            }
            else
            {
                Response.Redirect("/Home");
                return Json(new { message = "Redirected to /Home" });
            }
        }
        public IActionResult SearchCitizen()
        {
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            if (account != null && account.Role == 2 && account.Status == 1)
            {
                if (SessionHelper.GetObjectFromJson<Citizen>(HttpContext.Session, "CitizenProfile") == null)
                    LoadCitizenProfile();
                return View();
            }
            else
            {
                Response.Redirect("/Home");
                return Json(new { message = "Redirected to /Home" });
            }
        }
        public IActionResult AddRelative()
        {
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            if (account != null && account.Role == 2 && account.Status == 1)
            {
                if (SessionHelper.GetObjectFromJson<Citizen>(HttpContext.Session, "CitizenProfile") == null)
                    LoadCitizenProfile();
                return View();
            }
            else
            {
                Response.Redirect("/Home");
                return Json(new { message = "Redirected to /Home" });
            }
        }

        [HttpPost]
        public IActionResult UpdateAccount(string phone, string password, string new_password)
        {
            string message = "";
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            var conn = new OracleConnection();
            conn.ConnectionString = "User Id=covid19_vaccination_infogate;Password=covid19_vaccination_infogate;Data Source=localhost/orcl";
            conn.Open();

            string query = "select Password from ACCOUNT where Username = :username";
            var command = new OracleCommand(query, conn);
            command.Parameters.Add(new OracleParameter("username", account.Username));
            var reader = command.ExecuteReader();

            reader.Read();
            account.Password = reader["Password"] as string;
            conn.Close();

            /*CHECK ENTERED PASSWORD*/
            if (password != account.Password)
            {
                account.Password = null;
                return Json(new { message = "Password is incorrect!" });
            }
            account.Password = null;

            /*CHANGE PASSWORD*/
            if (new_password == null || new_password == account.Password)
                message += "!ChangePassword";
            else
            {
                command = new OracleCommand("ACC_UPDATE_PASSWORD", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("par_Username", OracleDbType.Varchar2).Value = phone;
                command.Parameters.Add("par_OldPass", OracleDbType.Varchar2).Value = password;
                command.Parameters.Add("par_NewPass", OracleDbType.Varchar2).Value = new_password;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                message = "ChangePassword";
            }

            /*UPDATE USERNAME*/
            if (account.Role == 2)
            {
                if (phone == account.Username)
                {
                    message += "!UpdateAccount";
                }
                else
                {
                    /*command = new OracleCommand("alter session set NLS_DATE_FORMAT='YYYY-MM-DD'" , conn);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();*/

                    Citizen citizen = SessionHelper.GetObjectFromJson<Citizen>(HttpContext.Session, "CitizenProfile");

                    command = new OracleCommand("CITIZEN_UPDATE_RECORD", conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("par_OldID", OracleDbType.Varchar2).Value = citizen.Id;
                    command.Parameters.Add("par_ID", OracleDbType.Varchar2).Value = citizen.Id;
                    command.Parameters.Add("par_LastName", OracleDbType.Varchar2).Value = citizen.LastName;
                    command.Parameters.Add("par_FirstName", OracleDbType.Varchar2).Value = citizen.FirstName;
                    command.Parameters.Add("par_Birthday", OracleDbType.Varchar2).Value = citizen.Birthday;
                    command.Parameters.Add("par_Gender", OracleDbType.Int16).Value = Int16.Parse(citizen.Gender(-2));
                    command.Parameters.Add("par_HomeTown", OracleDbType.Varchar2).Value = citizen.HomeTown;
                    command.Parameters.Add("par_ProvinceName", OracleDbType.Varchar2).Value = citizen.ProvinceName;
                    command.Parameters.Add("par_DistrictName", OracleDbType.Varchar2).Value = citizen.DistrictName;
                    command.Parameters.Add("par_TownName", OracleDbType.Varchar2).Value = citizen.TownName;
                    command.Parameters.Add("par_Street", OracleDbType.Varchar2).Value = citizen.Street;
                    command.Parameters.Add("par_Phone", OracleDbType.Varchar2).Value = phone;
                    command.Parameters.Add("par_OldPhone", OracleDbType.Varchar2).Value = citizen.Phone;
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();

                    message += "UpdateAccount";
                }
            }

            return Json(new { message = message });
        }

        [HttpPost]
        public IActionResult LoadCertificate()
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult UpdateProfile(string lastname, string firstname, int gender, string id, string birthday, string hometown, string province, string district, string town, string street, string email)
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult LoadRegistration(int status, int vaccine, int time)
        {
            string message = "";
            Citizen citizen = SessionHelper.GetObjectFromJson<Citizen>(HttpContext.Session, "CitizenProfile");

            var conn = new OracleConnection();
            conn.ConnectionString = "User Id=covid19_vaccination_infogate;Password=covid19_vaccination_infogate;Data Source=localhost/orcl";
            conn.Open();

            string query = "select SchedID, Name, ProvinceName, DistrictName, TownName, Street, TO_CHAR(OnDate, 'YYYY-MM-DD') OnDate, Time, NO, VaccineID, Serial, Status, DoseType, Image from ("
                            + "(select SchedID, Time, NO, Status, REG.DoseType, OrgID, OnDate, VaccineID, Serial, Image from("
                                + "(select ID, SchedID, NO, Time, Status, DoseType, Image from REGISTER where CitizenID = :citizenid) REG"
                                + "inner join"
                                + "(select ID, OrgID, OnDate, VaccineID, Serial from SCHEDULE) SCHED"
                                + "on"
                                + "REG.SchedID = SCHED.ID)"
                            + ") REG_SCHED"
                            + "inner join"
                            + "(select ID, Name, ProvinceName, DistrictName, TownName, Street from ORGANIZATION) ORG"
                            + "on REG_SCHED.OrgID = ORG.ID"
                        + ")"
                        + "where 1 = 1";

            if (status != -1)
                query += " and Status = :status";
            if (vaccine != -1)
                query += " and VaccineID = :vaccine";
            if (time != -1)
                query += " and Time = :time";
            query += " order by Status";

            var command = new OracleCommand(query, conn);
            command.Parameters.Add(new OracleParameter("citizenid", citizen.Id));
            if (status != -1)
                command.Parameters.Add(new OracleParameter("status", status));
            if (vaccine != -1)
                command.Parameters.Add(new OracleParameter("vaccine", vaccine));
            if (time != -1)
                command.Parameters.Add(new OracleParameter("time", time));
            var reader = command.ExecuteReader();

            Register reg = new Register();
            while (reader.Read())
            {
                reg.
            }

            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult CancelRegistration(string SchedID)
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult LoadOrg(string province, string district, string town)
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult LoadSchedule(string orogid, string startdate, string enddate, string vaccine )
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult CheckRegistration()
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult RegisterVaccination(string SchedID, string time, string dosetype)
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult MedicalList(string formdate2)
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult MedicalForm(string filleddate, string choice)
        {
            return Json(new { message = "" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
