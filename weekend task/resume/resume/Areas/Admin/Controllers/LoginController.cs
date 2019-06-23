using resume.DAL;
using resume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace resume.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private readonly ResumeContext db;

        public LoginController()
        {
            db = new ResumeContext();
        }

        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Signin(Admin admin)
        {
            bool isMatch = false;

            if (string.IsNullOrEmpty(admin.Email) || string.IsNullOrEmpty(admin.Password))
            {
                Session["loginError"] = "Email veya Password bosh qoyula bilmez!";
                return RedirectToAction("Index", "Login");
            }

            Admin adm = db.Admin.FirstOrDefault(a => a.Email == admin.Email);

            if (adm != null)
            {
                isMatch = Crypto.VerifyHashedPassword(adm.Password, admin.Password);

                if (isMatch)
                {
                    Session["isLogin"] = true;
                    Session["User"] = adm;
                    return RedirectToAction("Index", "About", new { area = "Admin" });
                }
            }

            Session["loginError"] = "Email veya Password sehvdir";
            return RedirectToAction("Index", "Login");

        }


        public ActionResult Signout()
        {
            Session["isLogin"] = null;
            Session["User"] = null;
            return RedirectToAction("Index", "Login");

        }

        public ActionResult HashPass()
        {
            string p = "test123";
            string hashedP = Crypto.HashPassword(p);

            return Content(hashedP);
        }
    }
}