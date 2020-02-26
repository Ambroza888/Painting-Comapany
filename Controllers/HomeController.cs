using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Paiting.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Paiting.Controllers
{
    public class HomeController : Controller
    {
        private MyContext DbContext;
        public HomeController(MyContext context)
        {
            DbContext = context;
        }
        //==================================================

        [HttpGet("")]
        public IActionResult Home()
        {
            return View();
        }


        [HttpGet("/Gallery")]
        public IActionResult Gallery()
        {
            return View("Gallery");
        }


        [HttpGet("/ContactUs")]
        public IActionResult ContactUs()
        {
            return View("ContactUs");
        }


        [HttpPost("/CreateReview")]
        public IActionResult CreateReview(Review review)
        {
            if(ModelState.IsValid)
            {
                if(review.Rating == 0)
                {
                    ModelState.AddModelError("Rating","Please, choose Rating");
                    return View("Reviews");
                }
                DbContext.Add(review);
                DbContext.SaveChanges();
                return Redirect("Reviews");
            }
            else
            {
                ViewBag.errors = ModelState.Values;
                return View("Reviews");
            }
        }

        [HttpGet("/Reviews")]
        public IActionResult Reviews()
        {
            List<Review> all_reviews = DbContext.Reviews.OrderByDescending(w => w.CreatedAt).ToList();
            ViewBag.all_reviews = all_reviews;
            return View("Reviews");
        }














        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
