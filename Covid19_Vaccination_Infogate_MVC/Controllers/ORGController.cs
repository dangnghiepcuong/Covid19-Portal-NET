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
    public class ORGController : Controller
    {
        private readonly ILogger<ORGController> _logger;

        public ORGController(ILogger<ORGController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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

        public IActionResult Schedule()
        {
            return View();
        }
        public IActionResult CreateSchedule()
        {
            return View();
        }
        public IActionResult Document()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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


    }
}
