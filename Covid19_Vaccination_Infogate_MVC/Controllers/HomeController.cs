using Covid19_Vaccination_Infogate_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Security.Principal;

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

                while (reader.Read())
                {
                        if (password == reader['PASSWORD']) {   // account existed, check password
        HttpContext.Session.SetString('AccountInfo',reader['USERNAME']);
        HttpContext.Session.SetString('AccountInfo',reader['PASSWORD']);
        HttpContext.Session.SetString('AccountInfo',reader['ROLE']);
        HttpContext.Session.SetString('AccountInfo',reader['STATUS']);

                            switch (HttpContext.Session.GetString('STATUS') {
            case 0:
                $sql = "select * from ORGANIZATION where ID = :id";    //check exist profile
                                break;
            case 1:
                $sql = "select * from ORGANIZATION where ID = :id";    //check exist profile
                                break;
            case 2:
                $sql = "select * from CITIZEN where Phone = :id";    //check exist profile
                                break;
                            }
        $command = oci_parse($connection, $sql);
                            oci_bind_by_name($command, ':id', $_POST['username']);

        $r = oci_execute($command);
                            if (!$r) {
            $exception = oci_error($command);
                                echo 'ERROR: '. $exception['code']. ' - '. $exception['message'];
                                return;
                            }

        reader2 = oci_fetch_array($command, OCI_BOTH | OCI_RETURN_NULLS);
                            if (reader2 == false) {
                                echo 'NoProfile';   //no profile existed
                                setcookie('username', $_POST['username']);
                                return;
                            }

        HttpContext.Session.SetString(['username'] = $_POST['username'];
                        } else
                        {    //wrong password;
                            echo 'incorrect password';
                        }
                    
                }
            }
            else
                return Json(new { message = "ERROR: Connection Fail!" }); 
            conn.Close();



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
    }
}
