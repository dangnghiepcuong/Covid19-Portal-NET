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
    public class CitizenController : Controller
    {
        private readonly ILogger<CitizenController> _logger;

        public CitizenController(ILogger<CitizenController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MedicalForm()
        {
            return View();
        }

        public IActionResult MedicalFormList()
        {
            return View();
        }

        public IActionResult Vaccination()
        {
            return View();
        }

        public IActionResult AccountInfo()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Certificate()
        {
            return View();
        }
        public IActionResult SearchCitizen()
        {
            return View();
        }
        public IActionResult AddRelative()
        {
            return View();
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
        public IActionResult HandleMedicalList(string formdate2)
        {
            return Json(new { message = "" });
        }

        [HttpPost]
        public IActionResult HandleMedicalForm(string filleddate, string choice)
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
