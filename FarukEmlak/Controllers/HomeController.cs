using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FarukEmlak.Models;
using Microsoft.AspNetCore.Authorization;

namespace FarukEmlak.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult ilanversec()
        {
            return View();
        }


        [Authorize]

        [HttpGet]
        public IActionResult ilanverkir()
        {

            return View();
        }
        [HttpPost]
        public IActionResult ilanverkir(Kiralik kir)
        {
            c.Kiraliks.Add(kir);
            c.SaveChanges();
            ViewBag.alan = "İlan";
            return RedirectToAction("cikti");
        }

        [HttpGet]
        public IActionResult ilanversat()
        {

            return View();
        }
        [HttpPost]
        public IActionResult ilanversat(Satilik sat)
        {
            c.Satiliks.Add(sat);
            c.SaveChanges();
            ViewBag.alan = "İlan";
            return RedirectToAction("cikti");
        }
        public IActionResult cikti()
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
