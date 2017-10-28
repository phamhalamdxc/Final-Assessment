using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using COmpStore.Services;

namespace COmpStore.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        ICategoryService CategoryService;

        public CategoryController(ICategoryService categoryService)
        {
            CategoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var categories = CategoryService.GetAll();
            return Ok(categories);
        }

        [HttpPut]
        public IActionResult Put()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Post()
        {
            return View();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return View();
        }
    }
}