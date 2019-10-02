using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvctest.Models;

namespace mvctest.Controllers
{

    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(string Bart)
        {
            ViewData["title"] = 42;
            var v = View();
            return v;
        }

        [HttpPost]
        public IActionResult Index(string FirstName, string LastName, string CanBoogie)
        {
            bool isValid = true;
            if (FirstName is null || FirstName.Length == 0 || FirstName == "Mike")
            {
                isValid = false;
            }
            if (LastName is null || LastName.Length == 0 || LastName == "Dowell")
            {
                isValid = false;
            }

            if (isValid)
            {
                return RedirectToAction("Index", "Attendance");
            }

            return View();
        }

        public IActionResult Privacy()
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
