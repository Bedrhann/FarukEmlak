using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FarukEmlak.Controllers
{
    public class YoneticiController : Controller
    {
        public IActionResult Homeadmin()
        {

            return View();
        }
    }
}
