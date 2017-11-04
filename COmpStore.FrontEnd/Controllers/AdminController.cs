﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace COmpStore.FrontEnd.Controllers
{
    public class AdminController : Controller
    {
        // GET: /<controller>/
        [Route("/admin-login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("/home")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
