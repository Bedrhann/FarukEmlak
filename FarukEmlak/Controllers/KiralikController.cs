using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FarukEmlak.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace FarukEmlak.Controllers
{
    public class KiralikController : Controller
    {
        Context c = new Context();
      
        //public IActionResult Listele()
        //{
        //    var list = c.Kiraliks.ToList();
        //    return View(list);
        //}
         
        public IActionResult Listele2()
        {
            var list = c.Kiraliks.ToList();
            return View(list);
        }
       
        public IActionResult parcalistele()
        {
            var list = c.Kiraliks.ToList();
            return View(list);
        }
        [Authorize]
    
        public IActionResult Bilgi(int id)
        {
            var kira = c.Kiraliks.Include(a => a.Musteri).Where(x=> x.KiralikID == id).ToList();          
            return View(kira);
        }

       


    }


}
