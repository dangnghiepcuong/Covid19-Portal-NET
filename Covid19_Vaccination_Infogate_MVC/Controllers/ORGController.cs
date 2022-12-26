using Covid19_Vaccination_Infogate_MVC.Models;
using Covid19_Vaccination_Infogate_MVC.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Reflection;
using System.Web.Helpers;

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
                org.Id = reader["ID"] as string;
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

        public IActionResult Statistic()
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

        [HttpPost]
        public IActionResult CreateSchedule(string orgid, string date, string vaccine, string serial, int limitday, int limitnoon, int limitnight)
        {
            string message = "";
            Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            var conn = new OracleConnection();
            conn.ConnectionString = "User Id=covid19_vaccination_infogate;Password=covid19_vaccination_infogate;Data Source=localhost/orcl";
            conn.Open();

            var command = new OracleCommand("SCHED_INSERT_RECORD", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("par_OrgID", OracleDbType.Varchar2).Value = orgid;
            command.Parameters.Add("par_OnDate", OracleDbType.Varchar2).Value = date;
            command.Parameters.Add("par_VaccineID", OracleDbType.Varchar2).Value = vaccine;
            command.Parameters.Add("par_Serial", OracleDbType.Varchar2).Value = serial;
            command.Parameters.Add("par_LimitDay", OracleDbType.Int16).Value = limitday;
            command.Parameters.Add("par_LimitNoon", OracleDbType.Int16).Value = limitnoon;
            command.Parameters.Add("par_LimitNight", OracleDbType.Int16).Value = limitnight;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                message = e.Message;
                return Content(message, "text/html");
            };
            conn.Close();

            message = "CreateSchedule";
            return Content(message, "text/html");
        }

        [HttpPost]
        public IActionResult UpdateOrgProfile(string name, string district, string town, string street)
        {
            string message = "";
            var conn = new OracleConnection();
            conn.ConnectionString = "User Id=covid19_vaccination_infogate;Password=covid19_vaccination_infogate;Data Source=localhost/orcl";

            Organization org = SessionHelper.GetObjectFromJson<Organization>(HttpContext.Session, "ORGProfile");
            conn.Open();
            var command = new OracleCommand("ORG_UPDATE_RECORD", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("par_ID", OracleDbType.Varchar2).Value = org.Id;
            command.Parameters.Add("par_Name", OracleDbType.Varchar2).Value = name;
            command.Parameters.Add("par_DistrictName", OracleDbType.Varchar2).Value = district;
            command.Parameters.Add("par_TownName", OracleDbType.Varchar2).Value = town;
            command.Parameters.Add("par_Street", OracleDbType.Varchar2).Value = street;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                message = e.Message;
            };
            conn.Close();

            message += "UpdateProfile";

            org.Name = name;
            org.DistrictName = district;
            org.TownName = town;
            org.Street = street;

            SessionHelper.SetObjectAsJson(HttpContext.Session, "ORGProfile", org);

            return Content(message, "text/html");
        }

        [HttpPost]
        public IActionResult LoadSchedule(string startdate, string enddate, string vaccine)
        {
            string message = "";
            var conn = new OracleConnection();
            conn.ConnectionString = "User Id=covid19_vaccination_infogate;Password=covid19_vaccination_infogate;Data Source=localhost/orcl";
            conn.Open();
            string orgid = SessionHelper.GetObjectFromJson<Organization>(HttpContext.Session, "ORGProfile").Id;

            string query = "select * from SCHEDULE where OrgID = :id";

            if (startdate != null)
                query += " and OnDate >= TO_DATE(:startdate, 'YYYY-MM-DD')";
            if (enddate != null)
                query += " and OnDate <= TO_DATE(:enddate, 'YYYY-MM-DD')";
            if (vaccine != null)
                query += " and VaccineID = :vaccine";
            query += " order by OnDate";

            var command = new OracleCommand(query, conn);

            command.Parameters.Add(new OracleParameter("id", orgid));
            if (startdate != null)
                command.Parameters.Add(new OracleParameter("startdate", startdate));
            if (enddate != null)
                command.Parameters.Add(new OracleParameter("enddate", enddate));
            if (vaccine != null)
                command.Parameters.Add(new OracleParameter("vaccine", vaccine));

            string html = "";
            try
            {
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DateTime date = (DateTime)reader["ONDATE"];
                    string CancelButton = "";
                    if (date > DateTime.Now)
                        CancelButton = "<button class='btn-short-bordered btn-cancel'>Hủy</button>";

                    html += "<div class='schedule object' id='" + reader["ID"] + "'>"
                            + "<div class='holder-schedule'>"
                            + "<div class='obj-attr'>"
                                + "<p class='attr-date-vaccine-serial'>Ngày tiêm: " + date.ToString("yyyy/MM/dd") + " - Vaccine:"
                                + reader["VACCINEID"] + " - " + reader["SERIAL"] + "</p>"
                                + "<div class='attr-time'>"
                                    + "<p>Buổi sáng: " + reader["DAYREGISTERED"] + "/</p><p class='day' id='" + reader["LIMITDAY"] + "'>" + reader["LIMITDAY"] + "</p>"
                                    + "<p>&nbsp- Buổi trưa: " + reader["NOONREGISTERED"] + "/</p><p class='noon' id='" + reader["LIMITNOON"] + "'>" + reader["LIMITNOON"] + "</p>"
                                    + "<p>&nbsp- Buổi tối: " + reader["NIGHTREGISTERED"] + "/</p><p class='night' id='" + reader["LIMITNIGHT"] + "'>" + reader["LIMITNIGHT"] + "</p>"
                                    + "</div>"
                                + "</div>"
                                + "<div class='interactive-area'>"
                                    + "<button class='btn-medium-filled btn-registration'>Lượt đăng ký</button>"
                                    + "<button class='btn-medium-bordered btn-update'>Cập nhật</button>"
                                    + CancelButton
                                + "</div>"
                            + "</div>"
                            + "<div class='holder-btn-expand-schedule'>"
                                + "<div class='btn-expand-schedule'> > </div>"
                            + "</div>"
                        + "</div>";
                }
            }
            catch (OracleException e)
            {
                message = e.Message;
                return Content(message, "text/html");
            }

            return Content(html, "text/html");
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
