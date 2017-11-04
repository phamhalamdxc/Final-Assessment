using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using COmpStore.FrontEnd.Models;
using COmpStore.FrontEnd.Builder;
using System.Net.Http;

namespace COmpStore.FrontEnd.Controllers
{
    public class HomeController : Controller
    {

        public async Task<IActionResult> Index()
        {
            const string baseUri = "http://localhost:2693/api/category";
            var requestUri = $"{baseUri}";
            var response = await HttpRequestFactory.Get(requestUri, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJtcnRlYUBnbWFpbC5jb20iLCJqdGkiOiIzOWI0ZmRjMS04NTVkLTQzNjItYmI1MS04ODMyZWI2NDRmNGUiLCJlbWFpbCI6Im1ydGVhQGdtYWlsLmNvbSIsImV4cCI6MTUwOTQ2NTM3MCwiaXNzIjoiaHR0cDovL2xvY2FsaG9zdDo2MDI2OCIsImF1ZCI6Imh0dHA6Ly9sb2NhbGhvc3Q6NjAyNjgifQ.yP2vdE8iRw4TkOGfDHMbYtB0IGigefGfXfAKQosLuEE");

            Console.WriteLine($"Status: {response.StatusCode}");
            //Console.WriteLine(response.ContentAsString());
            var outputModel = response.ContentAsType<List<CategoryModel>>();

            return View(outputModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
