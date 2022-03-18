using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FarukEmlak.Controllers
{
    public class MusteriController : Controller
    {
        public IActionResult Listele()
        {
            Context c = new Context();
            var list = c.Musteris.ToList();
           
            return View(list);
        }
    }
}
