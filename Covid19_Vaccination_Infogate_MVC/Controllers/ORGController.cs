using Covid19_Vaccination_Infogate_MVC.Models;
using Covid19_Vaccination_Infogate_MVC.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using Oracle.ManagedDataAccess.Client;

namespace Covid19_Vaccination_Infogate_MVC.Controllers
{
    public class ORGController : Controller
    {
        private readonly ILogger<ORGController> _logger;

        public ORGController(ILogger<ORGController> logger)
        {
            _logger = logger;
        }

        public void LoadORGProfile()
        {
            Organization org = new Organization();
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");

            SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            var conn = new OracleConnection();
            conn.ConnectionString = "User Id=covid19_vaccination_infogate;Password=covid19_vaccination_infogate;Data Source=localhost/orcl";
            conn.Open();

            string query = "select * from Organization where ID = :username";
            var command = new OracleCommand(query, conn);
            command.Parameters.Add(new OracleParameter("userName", account.Username));
            var reader = command.ExecuteReader();

            if (reader.HasRows == false)
                return;

            while (reader.Read())
            {
                org.ID = reader["ID"] as string;
                org.Name = reader["NAME"] as string;
                org.ProvinceName = reader["PROVINCENAME"] as string;
                org.DistrictName = reader["DISTRICTNAME"] as string;
                org.TownName = reader["TOWNNAME"] as string;
                org.Street = reader["STREET"] as string;
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "ORGProfile", org);

            return;
        }

        public IActionResult Index()
        {
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            if (account != null && account.Role < 2)
            {
                if (SessionHelper.GetObjectFromJson<Organization>(HttpContext.Session, "ORGProfile") == null)
                    LoadORGProfile();
                return View();
            }
            else
            {
                Response.Redirect("/Home");
                return Json(new { message = "Redirected to /Home" });
            }
            return Profile();
        }
        
        public IActionResult AccountInfo()
        {
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            if (account != null && account.Role < 2)
            {
                if (SessionHelper.GetObjectFromJson<Organization>(HttpContext.Session, "ORGProfile") == null)
                    LoadORGProfile();
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
            if (account != null && account.Role < 2)
            {
                if (SessionHelper.GetObjectFromJson<Organization>(HttpContext.Session, "ORGProfile") == null)
                    LoadORGProfile();
                return View();
            }
            else
            {
                Response.Redirect("/Home");
                return Json(new { message = "Redirected to /Home" });
            }
        }

        public IActionResult Schedule()
        {
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            if (account != null && account.Role == 1)
            {
                if (SessionHelper.GetObjectFromJson<Organization>(HttpContext.Session, "ORGProfile") == null)
                    LoadORGProfile();
                return View();
            }
            else
            {
                Response.Redirect("/Home");
                return Json(new { message = "Redirected to /Home" });
            }
        }
        public IActionResult CreateSchedule()
        {
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            if (account != null && account.Role == 1)
            {
                if (SessionHelper.GetObjectFromJson<Organization>(HttpContext.Session, "ORGProfile") == null)
                    LoadORGProfile();
                return View();
            }
            else
            {
                Response.Redirect("/Home");
                return Json(new { message = "Redirected to /Home" });
            }
        }
        public IActionResult Document()
        {
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            if (account != null && account.Role < 2)
            {
                if (SessionHelper.GetObjectFromJson<Organization>(HttpContext.Session, "ORGProfile") == null)
                    LoadORGProfile();
                return View();
            }
            else
            {
                Response.Redirect("/Home");
                return Json(new { message = "Redirected to /Home" });
            }
        }       

        [HttpPost]
        public IActionResult CreateSchedule(string ordid, string date, string vaccine, string limitday, string limitnoon, string limitnight)
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult UpdateOrgProfile(string name, string district, string town, string street)
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult LoadSchedule(string orgid, string startdate, string enddate, string vaccine)
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult LoadScheduleRegistration(string SchedID, string SchedInfo)
        {
            return Json(new { message = "" });
        }


        [HttpPost]
        public IActionResult UpdateRegistrationStatus(string citizenid, string SchedID, string status)
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult SelectScheduleValue(string SchedID)
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult UpdateSchedule(string SchedID, string limitday, string limitnoon, string limitnight)
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult CancelSchedule(string SchedID)
        {
            return Json(new { message = "" });
        }

        
        /*MOH method*/
        public IActionResult ManageOrg()
        {
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            if (account != null && account.Role == 0)
            {
                if (SessionHelper.GetObjectFromJson<Organization>(HttpContext.Session, "ORGProfile") == null)
                    LoadORGProfile();
                return View();
            }
            else
            {
                Response.Redirect("/Home");
                return Json(new { message = "Redirected to /Home" });
            }
        }
        public IActionResult ProvideOrgAcc()
        {
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            if (account != null && account.Role == 0)
            {
                if (SessionHelper.GetObjectFromJson<Organization>(HttpContext.Session, "ORGProfile") == null)
                    LoadORGProfile();
                return View();
            }
            else
            {
                Response.Redirect("/Home");
                return Json(new { message = "Redirected to /Home" });
            }
        }

        [HttpPost]
        public IActionResult LoadOrg(string province, string district, string town)
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult ProvideAccount(string quantity, string code, string province)
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
