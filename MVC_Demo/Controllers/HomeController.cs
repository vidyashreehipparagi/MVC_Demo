﻿using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;
using System.Diagnostics;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       

        public IActionResult Index()
        {
            ViewData["message"] = "Welecome to MVC Demo";
            List<string> list = new List<string>()
            {
              "Red",
              "Black",
              "Green",
              "Pink",
              "White",
              "Yellow"
            };
            ViewData["colors"]=list;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
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