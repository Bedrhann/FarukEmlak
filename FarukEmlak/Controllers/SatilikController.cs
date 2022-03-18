using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarukEmlak.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FarukEmlak.Controllers
{
    public class SatilikController : Controller
    {
        Context c = new Context();

        public IActionResult Listele()
        {
            var list = c.Satiliks.ToList();
            return View(list);
        }
        [Authorize]

        public IActionResult Bilgi(int id)
        {
            var kira = c.Satiliks.Include(a => a.Musteri).Where(x => x.MusteriID == id ).ToList();
            return View(kira);
        }
    }
}
