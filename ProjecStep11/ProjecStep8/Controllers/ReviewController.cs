using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjecStep8.Models;

namespace ProjecStep8.Controllers
{
    public class ReviewController : Controller
    {
       
       

        [HttpGet]
        public IActionResult AddReview()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddReview(Review u)
        {
            return RedirectToAction("Details", u);
        }
        public IActionResult Details(Review u)
        {
            return View(u);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Review u = new Review();
            u.Id = Id;
            u.Userid = 0;
            u.Rating = 0;
            u.Comments = null;
            return View(u);

        }
        [HttpPost]
        public IActionResult Edit(Review u)
        {
            return RedirectToAction("Details", u);
        }

    }
}
