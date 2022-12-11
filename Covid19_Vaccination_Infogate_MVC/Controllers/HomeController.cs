using Covid19_Vaccination_Infogate_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

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
            return View();
        }

        public IActionResult Login(string username, string password)
        {
            var conn = new OracleConnection();
            conn.ConnectionString = "User Id=covid19_vaccination_infogate;Password=covid19_vaccination_infogate;Data Source=localhost/orcl";
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = "select * from ACCOUNT where Username = :username";
                var command = new OracleCommand(query, conn);
                command.Parameters.Add(new OracleParameter("userName", username));
                var reader = command.ExecuteReader();
            }
            else
                return Json(new { message = "ERROR: Connection Fail!" }); 
            conn.Close();



            return Json(new { message = "Login" });
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
    }
}
