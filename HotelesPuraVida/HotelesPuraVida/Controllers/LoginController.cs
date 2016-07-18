using HotelesPuraVida.Context;
using HotelesPuraVida.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelesPuraVida.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            using (OurDBContext db = new OurDBContext())
            {
                return View(db.UserAccout.ToList());
            }
        }
        //GET: Registro
        
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Login user)
        {
            if(ModelState.IsValid){
                using(OurDBContext db=new OurDBContext())
                {
                    db.UserAccout.Add(user);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = user.Name + " " + "Registrado exitosamente";
            }
            return View();
        }

        //Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login user)
        {
            using (OurDBContext db = new OurDBContext())
            {
                var usr = db.UserAccout.Where(u => u.Email == user.Email && u.Password == user.Password);
                if(usr!=null)
                {
                    Session["UserID"] = user.UserID.ToString();
                    Session["Email"] = user.Email.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Email o Contraseña es Incorrecto. ");
                }
                return View();
            }

        }
        public ActionResult LoggedIn()
        {
            if (Session["UserID"]!=null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }



    }
}