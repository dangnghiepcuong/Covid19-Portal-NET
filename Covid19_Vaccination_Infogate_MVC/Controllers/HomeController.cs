using Covid19_Vaccination_Infogate_MVC.Models;
using Covid19_Vaccination_Infogate_MVC.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Oracle.ManagedDataAccess.Client;
using System.IO;
using System.Reflection;
using System.Web.Helpers;

namespace Covid19_Vaccination_Infogate_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("AccountInfo") != null)
            {
                Account account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
                ViewBag.username = account.Username;
            }
            else
            {
                ViewBag.username = "NA";
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var conn = new OracleConnection();
            conn.ConnectionString = "User Id=covid19_vaccination_infogate;Password=covid19_vaccination_infogate;Data Source=localhost/orcl";
            conn.Open();
            Account account = new Account();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = "select * from ACCOUNT where Username = :username";
                var command = new OracleCommand(query, conn);
                command.Parameters.Add(new OracleParameter("userName", username));
                var reader = command.ExecuteReader();

                int RowCount = 0;

                while (reader.Read())
                {
                    RowCount++;
                    if (password == (string)reader["PASSWORD"])
                    {   // account existed, check password

                        switch (reader["STATUS"])
                        {
                            case 0:
                                query = "select * from ORGANIZATION where ID = :id";    //check exist profile
                                break;
                            case 1:
                                query = "select * from ORGANIZATION where ID = :id";    //check exist profile
                                break;
                            case 2:
                                query = "select * from CITIZEN where Phone = :id";    //check exist profile
                                break;
                        }

                        command = new OracleCommand(query, conn);
                        command.Parameters.Add(new OracleParameter("id", username));
                        reader = command.ExecuteReader();

                        if (reader.Read() == false)
                        {
                            return Json(new { message = "NoProfile" });   //no profile existed
                        }

                        account = new Account
                        {
                            Username = username,
                            Password = password,
                            Role = (int)reader["ROLE"],
                            Status = (int)reader["STATUS"]
                        };
                        SessionHelper.SetObjectAsJson(HttpContext.Session, "AccountInfo", account);

                        HttpContext.Session.SetString("username", username);
                        HttpContext.Session.SetString("password", password);
                        HttpContext.Session.SetInt32("role", (int)reader["ROLE"]);
                        HttpContext.Session.SetInt32("status", (int)reader["STATUS"]);
                    }
                    else
                    {    //wrong password;
                        return Json(new { message = "incorrect password" });
                    }
                }

                if (RowCount == 0)
                    return Json(new { message = "NoAccount" });
            }
            else
                return Json(new { message = "ERROR: Connection Fail!" }); 
            conn.Close();

            account = SessionHelper.GetObjectFromJson<Account>(HttpContext.Session, "AccountInfo");
            return Json(new { success = true, message = "Login" });
        }

        public IActionResult MedicalForm()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult HandleLogout()
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult RegisterCheckExist(string username)
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult RegisterAccount(string username, string password)
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult RegisterProfile(string lastname, string firstname, int gender, string id, string birthday, string hometown, string province, string district, string town, string street, string email)
        {
            return Json(new { message = "" });
        }
    }
}
