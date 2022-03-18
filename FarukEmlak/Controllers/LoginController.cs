using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FarukEmlak.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace FarukEmlak.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Kayit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kayit(Musteri mus)
        {
            c.Musteris.Add(mus);
            c.SaveChanges();
            return RedirectToAction("cikti","Home");
        }
     
        
//@{
//    ViewData["Title"] = "cikti";
//    Layout = "~/Views/Shared/_Layout.cshtml";
//}

//<h1 style = "margin-left:425px;font-size:30px" class="btn btn-success">@ViewBag.x Ekleme Başarılı</h1>
//<br /><br />


        [HttpGet]
        public IActionResult giris()
        {
            return View();
        }
        public async Task<IActionResult> giris(Musteri m)
        {
            var bilgiler = c.Musteris.FirstOrDefault(x => x.TCno == m.TCno && x.Parola == m.Parola);
            
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,m.TCno)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home");
            }

            //bilgiler = c.musteris.FirstOrDefault(x => x.TCno == "12345678999" && x.Parola == "1");
            //if (bilgiler != null)
            //{
            //    var claims = new List<Claim>
            //    {
            //        new Claim(ClaimTypes.Name,m.TCno)
            //    };
            //    var useridentity = new ClaimsIdentity(claims, "Home");
            //    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
            //    await HttpContext.SignInAsync(principal);
            //    return RedirectToAction("Privacy", "Home");
            //}

            return View();
        }

        [HttpGet]
        public IActionResult admin()
        {
            return View();
        }
        public async Task<IActionResult> admin(Admin a)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.TCno == a.TCno && x.Parola == a.Parola);

            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,a.TCno)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Homeadmin", "Yonetici");
            }

            

            return View();
        }

    }
}
