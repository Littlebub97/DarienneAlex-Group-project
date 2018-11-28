using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.Models.Entities;

namespace TimeSheet.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Manager()
        {
            ViewData["Message"] = "Manager";
                return View();
        }
        public IActionResult ClockIn()
        {
            ViewData["Message"] = "ClockIn";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "TimeSheet";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
