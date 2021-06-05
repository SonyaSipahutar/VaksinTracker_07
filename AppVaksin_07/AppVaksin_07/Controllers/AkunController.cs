using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppVaksin_07.Models;
using System.Data.SqlClient;
using System.Web.Security;

namespace AppVaksin_07.Controllers
{
    public class AkunController : Controller
    {
        Vaksin07_Entities db = new Vaksin07_Entities();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Akun akun)
        {
            using (Vaksin07_Entities context = new Vaksin07_Entities())
            {
                bool IsValidUser = context.Akuns.Any(x => x.username.ToLower() ==
                     akun.username.ToLower() && x.password == akun.password);
                if (IsValidUser)
                {
                    FormsAuthentication.SetAuthCookie(akun.username, false);
                    Response.Write("<script>alert('Anda Login Sebagai')</script>");
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    Response.Write("<script>alert('Username atau Pasword anda salah!!')</script>");
                }
                return View();
            }

        }
    }
}