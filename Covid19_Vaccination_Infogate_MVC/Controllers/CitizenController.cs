using Covid19_Vaccination_Infogate_MVC.Models;
using Covid19_Vaccination_Infogate_MVC.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Oracle.ManagedDataAccess.Client;
using System;

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
            command.Parameters.Add(new OracleParameter("userName", account.Username));
            var reader = command.ExecuteReader();

            if (reader.HasRows == false)
                return;

            while (reader.Read())
            {
                citizen.LastName = reader["LASTNAME"] as string;
                citizen.FirstName = reader["FIRSTNAME"] as string;
                citizen.Id = reader["ID"] as string;
                string date = reader["BIRTHDAY"] as string;
                citizen.Birthday = DateTime.Parse(date);
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

            return Json(new { message = "" });
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
        public IActionResult LoadRegistration(string status, string vaccine, string time)
        {
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
