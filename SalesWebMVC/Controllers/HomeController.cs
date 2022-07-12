using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SalesWebMVC.Models.ViewModels;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            
            ViewData["Message"] = "Sales Web MVC App from C# Course";
            ViewData["Aluno"] = "Artur Alves";

            return View();
        }

        public IActionResult Privacy()
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
