using asp.net_core_mvc_webapp_sample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace asp.net_core_mvc_webapp_sample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddEmployee()
        {
            ViewData["Message"] = "Add Employee";



            return View();
        }

        public IActionResult ViewEmployee()
        {
            ViewData["Message"] = "View Employee";

            return View();
        }

        public IActionResult EmployeeDetail()
        {
            ViewData["Message"] = "Employee Detail";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
