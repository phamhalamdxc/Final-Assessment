using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using COmpStore.FrontEnd.Models;

namespace COmpStore.FrontEnd.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int productId)
        {
            return View();
        }

        public IActionResult Update(int productId)
        {
            return View();
        }

        public IActionResult Delete(int productId)
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}