﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Paiting.Models;

namespace Paiting.Controllers
{
    public class HomeController : Controller
    {
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
        public IActionResult Reviews()
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
