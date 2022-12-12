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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
