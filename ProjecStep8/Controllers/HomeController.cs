using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjecStep8.Models;

namespace ProjecStep8.Controllers
{
        public class HomeController
            :Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Details(Review u)
        {
            return View(u);
        }
        public IActionResult AddAService()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddService()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Addservice(Addservice addservice)
        {
            return View();
        }
    }
}
